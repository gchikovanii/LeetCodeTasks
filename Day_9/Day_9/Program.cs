#region Task1
//Given a pattern and a string s, find if s follows the same pattern.

//Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.



//Example 1:

//Input: pattern = "abba", s = "dog cat cat dog"
//Output: true
//Example 2:

//Input: pattern = "abba", s = "dog cat cat fish"
//Output: false
//Example 3:

//Input: pattern = "aaaa", s = "dog cat cat dog"
//Output: false




//bool WordPattern(string pattern, string s)
//{
//    Dictionary<string, string> dic = new Dictionary<string, string>();
//    StringBuilder sb = new StringBuilder();
//    string[] ss = s.Split(' ');
//    if (pattern.Length != ss.Length)
//        return false;
//    foreach (string s2 in ss)
//    {
//        sb.Append(s2);
//    }
//    for (int i = 0; i < pattern.Length - 1; i++)
//    {
//        for (int j = i; j < ss.Length; j++)
//        {
//            if (!dic.ContainsKey(pattern[i].ToString()))
//                dic.Add(pattern[i].ToString(), ss[j]);
//            break;
//        }
//    }
//    StringBuilder stringBuilder = new StringBuilder();
//    foreach (var item in pattern)
//    {
//        if (dic.ContainsKey(item.ToString()))
//        {
//            dic.TryGetValue(item.ToString(), out string result);
//            stringBuilder.Append(result);
//        }
//    }
//    if(sb.ToString() == stringBuilder.ToString()) 
//        return true;
//    return false;
//}






//Solution 2
//bool WordPattern(string pattern, string s)
//{
//    var dict1 = new Dictionary<char, string>();
//    var dict2 = new Dictionary<string, char>();
//    var sList = s.Split(' ');

//    if (pattern.Length != sList.Count())
//        return false;

//    for (int i = 0; i < sList.Count(); i++)
//    {
//        dict1.TryAdd(pattern[i], sList[i]);
//        dict2.TryAdd(sList[i], pattern[i]);
//        if (dict1[pattern[i]] != sList[i]) 
//            return false;
//        if (dict2[sList[i]] != pattern[i]) 
//            return false;
//    }
//    return true;

//}
//Console.WriteLine(WordPattern("abba", "dog cat cat dog"));
//Console.WriteLine(WordPattern("abba", "dog cat cat fish"));
//Console.WriteLine(WordPattern("aaaa", "dog cat cat dog"));

#endregion

#region Task2


//You are playing the following Nim Game with your friend:

//Initially, there is a heap of stones on the table.
//You and your friend will alternate taking turns, and you go first.
//On each turn, the person whose turn it is will remove 1 to 3 stones from the heap.
//The one who removes the last stone is the winner.
//Given n, the number of stones in the heap, return true if you can win the game assuming both you and your friend play optimally, otherwise return false.



//Example 1:

//Input: n = 4
//Output: false
//Explanation: These are the possible outcomes:
//1.You remove 1 stone. Your friend removes 3 stones, including the last stone. Your friend wins.
//2. You remove 2 stones. Your friend removes 2 stones, including the last stone. Your friend wins.
//3. You remove 3 stones. Your friend removes the last stone. Your friend wins.
//In all outcomes, your friend wins.
//Example 2:

//Input: n = 1
//Output: true
//Example 3:

//Input: n = 2
//Output: true
//bool CanWinNim(int n)
//{
//    return n % 4 != 0;
//}
//Console.WriteLine(CanWinNim(4));
//Console.WriteLine(CanWinNim(1));
//Console.WriteLine(CanWinNim(2));




#endregion
