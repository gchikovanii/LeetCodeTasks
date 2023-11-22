#region City Parser
//using Google.Cloud.Translation.V2;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        // Replace with your Google Cloud project ID
//        string projectId = "precise-antenna-404817";

//        // Replace with the API key for the Translation API
//        string apiKey = "AIzaSyDCNqQNkxTehriksSEH6_j_e44lWSpYe4c";

//        TranslationClient client = TranslationClient.CreateFromApiKey(apiKey);

//        // Load the JSON data from the file
//        string jsonData = File.ReadAllText(@"D:\RandomTask\Parser\Parser\cities.json");

//        // Deserialize the JSON data into a list of dictionaries
//        List<Dictionary<string, object>> cities = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonData);

//        // Extract the names to be translated
//        List<string> namesToTranslate = cities.Select(city => city["name"].ToString()).ToList();

//        // Translate the names
//        Dictionary<string, string> translatedNames = TranslateNames(client, namesToTranslate, "en", "ka");

//        // Create a simplified list with only the translated names
//        List<Dictionary<string, string>> simplifiedCities = new List<Dictionary<string, string>>();

//        foreach (var city in cities)
//        {
//            string originalName = city["name"].ToString();
//            if (translatedNames.TryGetValue(originalName, out string translatedName))
//            {
//                var simplifiedCity = new Dictionary<string, string>
//                {
//                    {"name", translatedName}
//                };
//                simplifiedCities.Add(simplifiedCity);
//            }
//        }

//        // Serialize the simplified list to a new JSON file
//        string outputJsonData = JsonConvert.SerializeObject(simplifiedCities, Newtonsoft.Json.Formatting.Indented);
//        File.WriteAllText(@"D:\RandomTask\Parser\Parser\translated_cities.json", outputJsonData);

//        client.Dispose();
//    }

//    static Dictionary<string, string> TranslateNames(TranslationClient client, List<string> names, string sourceLanguage, string targetLanguage)
//    {
//        Dictionary<string, string> translatedNames = new Dictionary<string, string>();

//        // Google Cloud Translation API has a limit of 128 strings per request
//        const int batchSize = 128;
//        for (int i = 0; i < names.Count; i += batchSize)
//        {
//            var batch = names.Skip(i).Take(batchSize).ToList();
//            var response = client.TranslateText(batch, targetLanguage, sourceLanguage);

//            for (int j = 0; j < response.Count; j++)
//            {
//                translatedNames[batch[j]] = response[j].TranslatedText;
//            }
//        }

//        return translatedNames;
//    }
//}
#endregion


#region Movies Checker
//using System;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Google.Cloud.Translation.V2;
//using Newtonsoft.Json.Linq;

//class Program
//{
//    static async Task Main()
//    {
//        #region Translate
//        string projectId = "precise-antenna-404817";
//        string apiKey = "AIzaSyDCNqQNkxTehriksSEH6_j_e44lWSpYe4c";
//        TranslationClient client = TranslationClient.CreateFromApiKey(apiKey);
//        string georgianWord = "მატრიცა"; 
//        string movieTitle = TranslateToEnglish(client, georgianWord);

//        #endregion

//        #region IMBD
//        string aKey = "ac61573fdfaa2012470f1ed42eba61b0";
//        string language = "en"; 
//        #endregion

//        bool exists = await CheckMovieExists(aKey, movieTitle, language);

//        if (exists)
//        {
//            Console.WriteLine($"The movie '{movieTitle}' exists!");
//        }
//        else
//        {
//            Console.WriteLine($"The movie '{movieTitle}' does not exist");
//        }
//    }
//    static string TranslateToEnglish(TranslationClient client, string georgianText)
//    {
//        var response = client.TranslateText(
//            text: georgianText,
//            targetLanguage: "en"
//        );

//        return response.TranslatedText;
//    }
//    static async Task<bool> CheckMovieExists(string apiKey, string movieTitle, string language = "en")
//    {
//        using (HttpClient client = new HttpClient())
//        {
//            string baseUrl = "https://api.themoviedb.org/3/search/movie";
//            string apiKeyParam = $"api_key={apiKey}";
//            string queryParam = $"query={Uri.EscapeDataString(movieTitle)}";
//            string languageParam = $"language={language}";

//            string url = $"{baseUrl}?{apiKeyParam}&{queryParam}&{languageParam}";

//            HttpResponseMessage response = await client.GetAsync(url);

//            if (response.IsSuccessStatusCode)
//            {
//                string json = await response.Content.ReadAsStringAsync();
//                JObject data = JObject.Parse(json);

//                if (data["results"].HasValues)
//                {
//                    var movies = data["results"]
//                        .Where(movie => movie["original_language"]?.ToString() == language)
//                        .ToList();

//                    return movies.Count > 0;
//                }
//            }
//            return false;
//        }
//    }
//}




#endregion