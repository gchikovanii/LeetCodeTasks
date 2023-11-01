#region Task1


//using System.Runtime.Intrinsics.X86;
//using System.Xml.Linq;
//using System;

//Implement a first in first out (FIFO) queue using only two stacks.The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).

//Implement the MyQueue class:

//void push(int x) Pushes element x to the back of the queue.
//int pop() Removes the element from the front of the queue and returns it.
//int peek() Returns the element at the front of the queue.
//boolean empty() Returns true if the queue is empty, false otherwise.
//Notes:

//You must use only standard operations of a stack, which means only push to top, peek/pop from top, size, and is empty operations are valid.
//Depending on your language, the stack may not be supported natively. You may simulate a stack using a list or deque(double-ended queue) as 
//    long as you use only a stack's standard operations.


//Example 1:

//Input
//["MyQueue", "push", "push", "peek", "pop", "empty"]
//[[], [1], [2], [], [], []]
//Output
//[null, null, null, 1, 1, false]

//Explanation
//MyQueue myQueue = new MyQueue();
//myQueue.push(1); // queue is: [1]
//myQueue.push(2); // queue is: [1, 2] (leftmost is front of the queue)
//myQueue.peek(); // return 1
//myQueue.pop(); // return 1, queue is [2]
//myQueue.empty(); // return false

//public class MyQueue
//{

//    Stack<int> firstStack;
//    Stack<int> secondStack;
//    public MyQueue()
//    {
//        firstStack = new Stack<int>();
//        secondStack = new Stack<int>();
//    }

//    public void Push(int x)
//    {
//        firstStack.Push(x);
//    }

//    public int Pop()
//    {
//        if (Empty())
//            return default;
//        while (firstStack.Count != 0)
//            secondStack.Push(firstStack.Pop());
//        int top = secondStack.Pop();
//        while (secondStack.Count != 0)
//            firstStack.Push(secondStack.Pop());
//        return top;
//    }

//    public int Peek()
//    {
//        if (Empty())
//            return default;
//        while (firstStack.Count != 0)
//            secondStack.Push(firstStack.Pop());
//        int top = secondStack.Peek();
//        while (secondStack.Count != 0)
//            firstStack.Push(secondStack.Pop());
//        return top;
//    }

//    public bool Empty()
//    {
//        return firstStack.Count == 0;
//    }
//}









#endregion


#region Task2
//Given an integer n, return true if it is a power of two. Otherwise, return false.

//An integer n is a power of two, if there exists an integer x such that n == 2x.



//Example 1:

//Input: n = 1
//Output: true
//Explanation: 20 = 1
//Example 2:

//Input: n = 16
//Output: true
//Explanation: 24 = 16
//Example 3:

//Input: n = 3
//Output: false

//bool IsPowerOfTwo(int n)
//{
//	int res = 0;

//	for (int i = 0; i < Int32.MaxValue; i++)
//	{
//        res = (int)Math.Pow(2,i);
//        if (res == n)
//            return true;
//        if(res > n)
//            return false;
//	}
//    return false;
//}

//Way 2 Bitwise Operator
//bool IsPowerOfTwo(int n)
//{
//    if(n < 0)
//        return false;
//    return ((n & (n - 1)) == 0);
//}
////Console.WriteLine(IsPowerOfTwo(1073741825));
//Console.WriteLine(IsPowerOfTwo(16));
//Console.WriteLine(IsPowerOfTwo(3));
//Console.WriteLine(IsPowerOfTwo(5));








#endregion

#region Task3
//Given two strings s and t, return true if t is an anagram of s, and false otherwise.

//An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.



//Example 1:

//Input: s = "anagram", t = "nagaram"
//Output: true
//Example 2:

//Input: s = "rat", t = "car"
//Output: false

//bool IsAnagram(string s, string t)
//{
//	//int count = 0;
//	//int count2 = 0;
//	//if(s.Length != t.Length)
//	//	return false;
//	//for (int i = 0; i < s.Length; i++)
//	//{
//	//	char c = s[i];
//	//	foreach (var item in t)
//	//	{
//	//		if(c == item)
//	//			count++;
//	//	}
//	//	foreach (var item in s)
//	//	{
// //           if (c == item)
// //               count2++;
// //       }
//	//	if(count == count2)
//	//		continue;
//	//	else if(count != count2)
//	//		return false;
//	//	count = 0;
//	//	count2 = 0;
//	//}
// //   return true;
//}


//Way 2
//bool IsAnagram(string s, string t)
//{
//   if(s.Length != t.Length) 
//        return false;
//      s = String.Concat(s.OrderBy(i => i));
//      t = String.Concat(t.OrderBy(i => i));
//    return s == t ? true : false;
//}
////Console.WriteLine(IsAnagram("anagram", "nagaram"));
//Console.WriteLine(IsAnagram("rat", "car"));
//Console.WriteLine(IsAnagram("a", "ab"));

#endregion