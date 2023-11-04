#region Task1

//write a function that reverses a string. The input string is given as an array of characters s.

//You must do this by modifying the input array in-place with O(1) extra memory.




//Example 1:

//Input: s = ["h", "e", "l", "l", "o"]
//Output: ["o","l","l","e","h"]
//Example 2:

//Input: s = ["H", "a", "n", "n", "a", "h"]
//Output: ["h","a","n","n","a","H"]

//using System.Text;

//void ReverseString(char[] s)
//{
//    Stack<char> stack = new Stack<char>();
//	StringBuilder stringBuilder = new StringBuilder();
//	foreach (var item in s)
//	{
//        stack.Push(item);
//	}
//	foreach (var item in stack)
//	{
//		stringBuilder.Append(item);
//    }
//}


//Soliton 2
//void ReverseString(char[] s)
//{
//    var left = 0;
//    var right = s.Length - 1;
//    while (left < right)
//    {
//        var temp = s[left];
//        s[left] = s[right];
//        s[right] = temp;
//        left++;
//        right--;
//    }
//}
//ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });


#endregion
#region Task2
//Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in 
//    the result must be unique and you may return the result in any order.



//Example 1:

//Input: nums1 = [1, 2, 2, 1], nums2 = [2, 2]
//Output: [2]
//Example 2:

//Input: nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]
//Output: [9,4]
//Explanation: [4,9] is also accepted.

//int[] Intersection(int[] nums1, int[] nums2)
//{
//	List<int> result = new List<int>();
//	foreach (var item in nums1)
//	{
//		if (nums2.Contains(item))
//		{
//			result.Add(item);
//		}
//	}

//	int[] nums = result.Distinct().ToArray();
//	return nums;
//}
//Console.WriteLine(Intersection(new int[] { 1, 2, 2, 1 },new int[] { 2, 2 }));
//Console.WriteLine(Intersection(new int[] { 4, 9, 5 },new int[] { 9, 4, 9, 8, 4 }));

#endregion

