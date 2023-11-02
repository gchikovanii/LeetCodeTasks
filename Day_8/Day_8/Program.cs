#region Task1

//258.Add Digits
//Easy
//Topics
//Companies
//Hint
//Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.



//Example 1:

//Input: num = 38
//Output: 2
//Explanation: The process is
//38-- > 3 + 8-- > 11
//11-- > 1 + 1-- > 2
//Since 2 has only one digit, return it.
//Example 2:

//Input: num = 0
//Output: 0

//int AddDigits(int num)
//{
//    char[] chars = num.ToString().ToCharArray();
//    int result = 0;
//    foreach (char c in chars)
//    {
//        result += Int32.Parse(c.ToString());
//    }

//    while (result.ToString().Length > 1)
//    {
//        result = 0;
//        foreach (char c in chars)
//        {
//            result += Int32.Parse(c.ToString()); ;
//        }
//        chars = result.ToString().ToCharArray();
//    }
//    return result;
//}
//Console.WriteLine(AddDigits(38));
//Console.WriteLine(AddDigits(0));

#endregion



#region Task2 
//Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

//Note that you must do this in-place without making a copy of the array.



//Example 1:

//Input: nums = [0, 1, 0, 3, 12]
//Output: [1,3,12,0,0]
//Example 2:

//Input: nums = [0]
//Output: [0]


//void MoveZeroes(int[] nums)
//{
//	List<int> list = new List<int>();
//	int counter = 0;
//	for (int i = 0; i < nums.Length; i++)
//	{
//		if (nums[i] == 0)
//		{
//			counter++;
//        }
//		else
//		{
//			list.Add(nums[i]);
//		}
//	}
//	for (int i = 0; i < counter; i++)
//	{
//		list.Add(0);
//	}
//    Console.Write("[");
//    foreach (var item in list)
//	{
//        Console.Write(item + ",");
//    }
//    Console.Write("]");
//}


//Solution 2
//void MoveZeroes(int[] nums)
//{
//	int temp = 0;
//	for (int i = 0; i < nums.Length; i++)
//	{
//        if (nums[i] == 0)
//        {
//            temp = nums[i];
//            for (int j = i + 1; j < nums.Length; j++)
//            {
//                if (nums[j] != 0)
//                {
//                    nums[i] = nums[j];
//                    nums[j] = temp;
//                    break;
//                }
//            }
//        }
//    }
//}
//MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
//MoveZeroes(new int[] { 0});


#endregion