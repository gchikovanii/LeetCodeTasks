#region Task1

//Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

//You must implement a solution with a linear runtime complexity and use only constant extra space.



//Example 1:

//Input: nums = [2, 2, 1]
//Output: 1
//Example 2:

//Input: nums = [4, 1, 2, 1, 2]
//Output: 4
//Example 3:

//Input: nums = [1]
//Output: 1


//when applied to the same number twice XOR Operator returns 0

int SingleNumber(int[] nums)
{
	int res = 0;
	foreach (var item in nums)
	{
        res ^= item;
	}
	return res;
}
Console.WriteLine(SingleNumber(new int[] { 1, 0, 1 })); //0
Console.WriteLine(SingleNumber(new int[] { 2, 2, 1 })); //1
Console.WriteLine(SingleNumber(new int[] { 4, 1, 2, 1, 2 })); //4
Console.WriteLine(SingleNumber(new int[] { 1 })); //1












#endregion