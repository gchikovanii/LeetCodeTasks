#region Task 1
//1.Write a C# Sharp program that takes three letters and displays them in reverse order.
//Test Data
//Enter letter: b
//Enter letter: a
//Enter letter: t
//Expected Output :
//t a b


//void DisplayLettersInReverse()
//{
//  Stack<char> stack = new Stack<char>();
//	for (int i = 0; i < 3; i++)
//	{
//        Console.Write("Enter Letter: ");
//        char letter = Convert.ToChar(Console.ReadLine());
//        stack.Push(letter);
//    }
//    foreach (var item in stack)
//    {
//        Console.Write(item + " ");
//    }
//}
//DisplayLettersInReverse();


//2
//Write a C# program that prompts the user to input two numbers and divides them.
//Handle an exception when the user enters non-numeric values.

//void DivideNumbers()
//{
//    try
//    {
//        Console.WriteLine("Enter first Number");
//        int num1 = Int32.Parse(Console.ReadLine());
//        Console.WriteLine("Enter second Number");
//        int num2 = Int32.Parse(Console.ReadLine());
//        Console.WriteLine(num1 / num2);
//    }
//    catch (FormatException ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//    catch(DivideByZeroException ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//    catch(Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }


//}
//DivideNumbers();

//3
//34.Write a program in C# Sharp to find prime numbers within a range of numbers.
//Test Data :
//Input starting number of range: 1
//Input ending number of range : 50
//Expected Output :
//The prime number between 1 and 50 are :
//2 3 5 7 11 13 17 19 23 29 31 37 41 43 47





//Queue<int> queue = new Queue<int>();
//try
//{
//    Console.Write("Enter a Starting number: ");
//    int num1 = Int32.Parse(Console.ReadLine());
//    Console.Write("Enter a Ending number: ");
//    int num2 = Int32.Parse(Console.ReadLine());
//    int i = 0;
//    int count = 0;
//    for (i = num1; i <= num2; i++)
//    {
//        count = 0;
//        for (int j = 2; j <= i /2; j++)
//        {
//            if(i % j == 0)
//            {
//                count++;
//                break;
//            }
//        }
//        if (count == 0 && i != 1)
//        {
//            queue.Enqueue(i);
//        }
//    }
//    foreach (int q in queue)
//    {
//        Console.Write(q + " ");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

#endregion

#region LeetCode 
//1
//int[] TwoSum(int[] nums, int target)
//{
//    int i = 0;
//    int j = 0;
//    for (i = 0; i < nums.Length; i++)
//    {
//        for (j = i +1; j <= nums.Length - 1; j++)
//        {
//            if (nums[i] + nums[j] == target)
//            {
//                Console.WriteLine($"[{i}], [{j}]");
//                return new int[] { i, j};
//            }
//        }
//    }
//    return null;
//}
//TwoSum(new int[] { 2, 7, 11, 15 }, 9);


//2
//12321
using System.Text;

//bool IsPalindrome(int x)
//{
//    //string xToStr = x.ToString();
//    //if(string.IsNullOrEmpty(xToStr))
//    //    return false;
//    //Stack<char> stack = new Stack<char>();
//    //StringBuilder stringBuilder = new StringBuilder();
//    //foreach(char c in xToStr)
//    //{
//    //    stack.Push(c);
//    //}
//    //foreach (var item in stack)
//    //{
//    //    stringBuilder.Append(item);
//    //}
//    //if(stringBuilder.ToString() == xToStr)
//    //    return true;
//    //return false;
//}

//bool IsPalindrome(int x)
//{
//    StringBuilder stringBuilder = new StringBuilder();
//    string text = x.ToString();
//    for (int i = text.Length - 1; i >= 0; i--)
//    {

//        stringBuilder.Append(text[i]);
//    }
//    if(stringBuilder.ToString() == text)
//        return true;
//    return false;
//}
//Console.WriteLine(IsPalindrome(121));
//Console.WriteLine(IsPalindrome(-121));
//Console.WriteLine(IsPalindrome(-121));
//Console.WriteLine(IsPalindrome(10));

//3
//Dictionary<char, int> keyValuePairs = new Dictionary<char, int>() { };
//keyValuePairs.Add('I',1);
//keyValuePairs.Add('V', 5);
//keyValuePairs.Add('X', 10);
//keyValuePairs.Add('L',50);
//keyValuePairs.Add('C',100);
//keyValuePairs.Add('D',500);
//keyValuePairs.Add('M',1000);

//int RomanToInt(string s)
//{
//    int result = 0;
//    for (int i = 0; i <= s.Length - 1; i++)
//    {
//        if (i + 1 < s.Length)
//        {
//            if (s[i] == 'I' && s[i + 1] == 'V')
//            {
//                result += 4;
//                i++;
//            }
//           else  if (s[i] == 'I' && s[i + 1] == 'X')
//            {
//                result += 9;
//                i++;
//            }
//            else if(s[i] == 'X' && s[i + 1] == 'L')
//            {
//                result += 40;
//                i++;
//            }
//            else if(s[i] == 'X' && s[i + 1] == 'C')
//            {
//                result += 90;
//                i++;
//            }
//            else  if (s[i] == 'C' && s[i + 1] == 'D')
//            {
//                result += 400;
//                i++;
//            }
//            else if (s[i] == 'C' && s[i + 1] == 'M')
//            {
//                result += 900;
//                i++;
//            }
//            else
//            {
//                keyValuePairs.TryGetValue(s[i], out int res);
//                result += res;
//            }
//        }
//        else
//        {
//            keyValuePairs.TryGetValue(s[i], out int res);
//            result += res;
//        }
//    }
//    return result;
//}
//Console.WriteLine(RomanToInt("III "));
//Console.WriteLine(RomanToInt("LVIII"));
//Console.WriteLine(RomanToInt("MCMXCIV"));







#endregion