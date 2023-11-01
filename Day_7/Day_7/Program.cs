#region Task1




//Given two non-negative integers, num1 and num2 represented as string, return the sum of num1 and num2 as a string.

//You must solve the problem without using any built-in library for handling large integers (such as BigInteger). You must also not convert the inputs to integers directly.



//Example 1:

//Input: num1 = "11", num2 = "123"
//Output: "134"
//Example 2:

//Input: num1 = "456", num2 = "77"
//Output: "533"
//Example 3:

//Input: num1 = "0", num2 = "0"
//Output: "0"

using System.Numerics;

string AddStrings(string num1, string num2)
{
    var result = Double.Parse(num1) + Double.Parse(num2);
    return result.ToString();
}
Console.WriteLine(AddStrings("11", "123"));
Console.WriteLine(AddStrings("456", "77"));
Console.WriteLine(AddStrings("0", "0"));













#endregion