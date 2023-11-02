#region Task1






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