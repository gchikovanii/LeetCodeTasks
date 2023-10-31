#region Task1




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

//int[] PlusOne(int[] digits)
//{
//    for (int i = digits.Length - 1; i >= 0; i--)
//    {
//        digits[i] += 1;

//        if (digits[i] == 10) 
//            digits[i] = 0;
//        else 
//            return digits;
//    }
//    int[] newArray = new int[digits.Length + 1];
//    newArray[0] = 1;
//    return newArray;
//}
//Console.WriteLine(PlusOne(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }));
//Console.WriteLine(PlusOne(new int[] { 4, 3, 2, 2 }));
//Console.WriteLine(PlusOne(new int[] { 1, 2, 3 }));
//Console.WriteLine(PlusOne(new int[] { 0 }));

#endregion


#region Task2

//Given two binary strings a and b, return their sum as a binary string.



//Example 1:

//Input: a = "11", b = "1"
//Output: "100"
//Example 2:

//Input: a = "1010", b = "1011"
//Output: "10101"



//using System.Text;

//string AddBinary(string a, string b)
//{
//    StringBuilder sb = new StringBuilder();
//    int i = a.Length - 1;
//    int j = b.Length - 1;
//    int carriage = 0;

//    for (; i >= 0 || j >= 0; i--, j--) { 

//        carriage += (i >= 0 ? a[i] - 48 : 0);   
//        carriage += (j >= 0 ? b[j] - 48 : 0);

//        sb.Insert(0, carriage % 2);
//        carriage = carriage / 2;
//    }

//    if (carriage > 0)
//        sb.Insert(0, carriage);

//    return sb.ToString();
//}



#endregion



#region Task3


//Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

//You must not use any built-in exponent function or operator.

//For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.


//Example 1:

//Input: x = 4
//Output: 2
//Explanation: The square root of 4 is 2, so we return 2.
//Example 2:

//Input: x = 8
//Output: 2
//Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.

//int MySqrt(int x)
//{
//    if (x < 0)
//        return 0;
//    return (int)Math.Sqrt(x);

//}
//Console.WriteLine(MySqrt(4));
//Console.WriteLine(MySqrt(8));
//Console.WriteLine(MySqrt(4));


#endregion

#region Task4

//using System.Threading;

//You are climbing a staircase. It takes n steps to reach the top.

//Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?



//Example 1:

//Input: n = 2
//Output: 2
//Explanation: There are two ways to climb to the top.
//1. 1 step + 1 step
//2. 2 steps
//Example 2:

//Input: n = 3
//Output: 3
//Explanation: There are three ways to climb to the top.
//1. 1 step + 1 step + 1 step
//2. 1 step + 2 steps
//3. 2 steps + 1 step


//int ClimbStairs(int n)
//{
//int fibonacciCount = 48;
//int firstNum = 0;
//int secondNum = 1;
//int swap = 0;

//int[] fibonacci = new int[fibonacciCount];
//fibonacci[0] = firstNum;
//fibonacci[1] = secondNum;
//for (int i = 2; i < fibonacciCount; i++)
//{
//    swap = firstNum + secondNum;
//    firstNum = secondNum;
//    secondNum = swap;
//    fibonacci[i] = swap;
//}
//return fibonacci[n + 1];
//}

//Console.WriteLine(ClimbStairs(2));
//Console.WriteLine(ClimbStairs(44));









#endregion


#region Task5

//A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing
//    all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

//Given a string s, return true if it is a palindrome, or false otherwise.



//Example 1:

//Input: s = "A man, a plan, a canal: Panama"
//Output: true
//Explanation: "amanaplanacanalpanama" is a palindrome.
//Example 2:

//Input: s = "race a car"
//Output: false
//Explanation: "raceacar" is not a palindrome.
//Example 3:

//Input: s = " "
//Output: true
//Explanation: s is an empty string "" after removing non-alphanumeric characters.
//Since an empty string reads the same forward and backward, it is a palindrome.


//bool IsPalindrome(string s)
//{
//    var result = s.ToUpper().Where(i => char.IsLetterOrDigit(i));
//    return result.Reverse().SequenceEqual(result);
//}
//Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
//Console.WriteLine(IsPalindrome("race a car"));
//Console.WriteLine(IsPalindrome(" "));





#endregion