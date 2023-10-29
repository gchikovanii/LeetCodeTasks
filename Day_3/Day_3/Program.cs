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