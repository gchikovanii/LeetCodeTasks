#region Task1
//given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that 
//    each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

//Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

//Change the array nums such that the first k elements of nums contain the unique elements in the order they
//    were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
//Return k.





//Example 1:

//Input: nums = [1, 1, 2]
//Output: 2, nums = [1, 2, _]
//Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
//It does not matter what you leave beyond the returned k (hence they are underscores).
//Example 2:

//Input: nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
//Output: 5, nums = [0, 1, 2, 3, 4, _, _, _, _, _]
//Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
//It does not matter what you 

//Solution 1
//int RemoveDuplicates(int[] nums)
//{
//    int length = nums.Length;
//	List<int> result = new List<int>();
//    int count = 0;
//	for (int i = 0; i < length; i++)
//	{
//        if (result.Any(k => k == nums[i]))
//            result.Add('_');
//        else
//        {
//            result.Add(nums[i]);
//            count++;
//        }

//    }
//    result.Sort();

//    for (int i = 0; i < result.Count; i++)
//    {
//        Console.Write(result[i] + ", ");
//    }
//	return count;
//}
//Console.WriteLine(RemoveDuplicates(new int[] {4, 3, 1, 2 ,3 ,4 }));
//Console.WriteLine(RemoveDuplicates(new int[] { 1,1,2 }));
//Console.WriteLine(RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));




//Solution 2

//int RemoveDuplicates(int[] nums)
//{
//    int i = 1;

//    foreach (int n in nums)
//    {
//        if (nums[i - 1] != n) 
//            nums[i++] = n;
//    }
//    return i;
//}




//Solution 3
//int RemoveDuplicates(int[] nums)
//{
//    int k = 1;
//    int prev = nums[0];
//    for (int i = 1; i < nums.Length; i++)
//    {
//        if (nums[i] != prev)
//        {
//            nums[k] = nums[i];
//            k++;
//        }
//        prev = nums[i];
//    }
//    return k;
//}

//Console.WriteLine(RemoveDuplicates(new int[] { 4, 3, 1, 2, 3, 4 }));
//Console.WriteLine(RemoveDuplicates(new int[] { 1, 1, 2 }));
//Console.WriteLine(RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));


#endregion

#region TASK2

//int RemoveElement(int[] nums, int val)
//{
//    int k = 0;
//    for (int j = 0; j < nums.Length; j++)
//    {
//        if (nums[j] != val) 
//        {
//            nums[k] = nums[j];
//            k++;
//        }

//    }
//    return k;
//}



//Console.WriteLine(RemoveElement(new int[] { 3, 2, 2, 3 },3));
//Console.WriteLine(RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 },2));






#endregion

#region Task3


//using System.Security.Cryptography;

//Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.



//Example 1:

//Input: haystack = "sadbutsad", needle = "sad"
//Output: 0
//Explanation: "sad" occurs at index 0 and 6.
//The first occurrence is at index 0, so we return 0.
//Example 2:

//Input: haystack = "leetcode", needle = "leeto"
//Output: -1
//Explanation: "leeto" did not occur in "leetcode", so we return -1.



//int StrStr(string haystack, string needle)
//{
//    if (haystack.StartsWith(needle))
//        return 0;
//    if(haystack.Contains(needle)) return haystack.IndexOf(needle);
//    return -1;
//}



//Console.WriteLine(StrStr("sadbutsad","sad"));
//Console.WriteLine(StrStr("leetcode", "leeto"));

#endregion

#region Task4

//Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

//You must write an algorithm with O(log n) runtime complexity.




//Example 1:

//Input: nums = [1, 3, 5, 6], target = 5
//Output: 2
//Example 2:

//Input: nums = [1, 3, 5, 6], target = 2
//Output: 1
//Example 3:

//Input: nums = [1, 3, 5, 6], target = 7
//Output: 4



//int SearchInsert(int[] nums, int target)
//{
//    int index = 0;



//	foreach (var item in nums)
//	{
//		if (item >= target)
//			return index;
//		index++;
//	}
//	return index;
//}


//Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 6},5));

#endregion

#region Task5

//int LengthOfLastWord(string s)
//{
//    var result = s.Split(' ');
//    if (String.IsNullOrWhiteSpace(result[result.Length - 1]) || String.IsNullOrEmpty(result[result.Length - 1]))
//    {
//        for (int i = result.Length - 1; i >= 0; i--)
//        {
//            if (result[i] == "")
//                continue;
//            else
//                return result[i].Length;
//        }
//    }
//    return result[result.Length - 1].Length;

//}
//Console.WriteLine(LengthOfLastWord("Hello World"));
//Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
//Console.WriteLine(LengthOfLastWord("luffy is still joyboy")); "day    "
//Console.WriteLine(LengthOfLastWord("a "));
//Console.WriteLine(LengthOfLastWord("day    "));
#endregion

#region Task6
//You are given a large integer represented as an integer array digits, where each digits[i] is the 
//    ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

//Increment the large integer by one and return the resulting array of digits.



//Example 1:

//Input: digits = [1, 2, 3]
//Output: [1,2,4]
//Explanation: The array represents the integer 123.
//Incrementing by one gives 123 + 1 = 124.
//Thus, the result should be [1, 2, 4].
//Example 2:

//Input: digits = [4, 3, 2, 1]
//Output: [4,3,2,2]
//Explanation: The array represents the integer 4321.
//Incrementing by one gives 4321 + 1 = 4322.
//Thus, the result should be [4, 3, 2, 2].
//Example 3:

//Input: digits = [9]
//Output: [1,0]
//Explanation: The array represents the integer 9.
//Incrementing by one gives 9 + 1 = 10.
//Thus, the result should be [1, 0].





#endregion