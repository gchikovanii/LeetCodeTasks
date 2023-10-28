#region 1

////Write a function to find the longest common prefix string amongst an array of strings.

////If there is no common prefix, return an empty string "".

////Example 1:

////Input: strs = ["flower", "flow", "flight"]
////Output: "fl"
////Example 2:

////Input: strs = ["dog", "racecar", "car"]
////Output: ""
////Explanation: There is no common prefix among the input strings.



string FindWithTwo(string s1, string s2)
{
    int i = 0;
    int j = 0;

    while (i < s1.Length && j < s2.Length)
    {
        if (s1[i] != s2[j])
            break;
        i++;
        j++;
    }
    string result = s1.Substring(0, i);
    return result;
}

string LongestCommonPrefix(string[] strs)
{
    string firstString = strs[0];
    foreach (var item in strs)
    {
        firstString = FindWithTwo(firstString, item);
    }
    return firstString;
}
Console.WriteLine(LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
Console.WriteLine(LongestCommonPrefix(new string[] { "dog", "racecar", "car"}));
Console.WriteLine(LongestCommonPrefix(new string[] { "acc", "aaa", "aaba" }));

#endregion