using Google.Cloud.Translation.V2;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class MovieHelper
    {
        static async Task Main()
        {
            #region Translate
            string projectId = "precise-antenna-404817";
            string apiKey = "AIzaSyDCNqQNkxTehriksSEH6_j_e44lWSpYe4c";
            TranslationClient client = TranslationClient.CreateFromApiKey(apiKey);
            string georgianWord = "მატრიცა";
            string movieTitle = TranslateToEnglish(client, georgianWord);

            #endregion

            #region IMBD
            string aKey = "ac61573fdfaa2012470f1ed42eba61b0";
            string language = "en";
            #endregion

            bool exists = await CheckMovieExists(aKey, movieTitle, language);

            if (exists)
            {
                Console.WriteLine($"The movie '{movieTitle}' exists!");
            }
            else
            {
                Console.WriteLine($"The movie '{movieTitle}' does not exist");
            }
        }
        static string TranslateToEnglish(TranslationClient client, string georgianText)
        {
            var response = client.TranslateText(
                text: georgianText,
                targetLanguage: "en"
            );

            return response.TranslatedText;
        }
        static async Task<bool> CheckMovieExists(string apiKey, string movieTitle, string language = "en")
        {
            using (HttpClient client = new HttpClient())
            {
                string baseUrl = "https://api.themoviedb.org/3/search/movie";
                string apiKeyParam = $"api_key={apiKey}";
                string queryParam = $"query={Uri.EscapeDataString(movieTitle)}";
                string languageParam = $"language={language}";

                string url = $"{baseUrl}?{apiKeyParam}&{queryParam}&{languageParam}";

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(json);

                    if (data["results"].HasValues)
                    {
                        var movies = data["results"]
                            .Where(movie => movie["original_language"]?.ToString() == language)
                            .ToList();

                        return movies.Count > 0;
                    }
                }
                return false;
            }
        }
    }
}
