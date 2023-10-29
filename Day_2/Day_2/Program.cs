#region 1

////Write a function to find the longest common prefix string amongst an array of strings.

////If there is no common prefix, return an empty string "".

////Example 1:

////Input: strs = ["flower", "flow", "flight"]
////Output: "fl"
////Example 2:

////Input: strs = ["dog", "racecar", "car"]
////Output: ""
////Explanation: There is no common prefix among the input strings.



//string FindWithTwo(string s1, string s2)
//{
//    int i = 0;
//    int j = 0;

//    while (i < s1.Length && j < s2.Length)
//    {
//        if (s1[i] != s2[j])
//            break;
//        i++;
//        j++;
//    }
//    string result = s1.Substring(0, i);
//    return result;
//}

//string LongestCommonPrefix(string[] strs)
//{
//    string firstString = strs[0];
//    foreach (var item in strs)
//    {
//        firstString = FindWithTwo(firstString, item);
//    }
//    return firstString;
//}
//Console.WriteLine(LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
//Console.WriteLine(LongestCommonPrefix(new string[] { "dog", "racecar", "car"}));
//Console.WriteLine(LongestCommonPrefix(new string[] { "acc", "aaa", "aaba" }));

#endregion

#region Taks 2
//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//An input string is valid if:

//Open brackets must be closed by the same type of brackets.
//Open brackets must be closed in the correct order.
//Every close bracket has a corresponding open bracket of the same type.



//Example 1:

//Input: s = "()"
//Output: true
//Example 2:

//Input: s = "()[]{}"
//Output: true
//Example 3:

//Input: s = "(]"
//Output: false


//bool IsValid(string s)
//{
//Stack<char> stack = new Stack<char>();


//foreach (var item in s)
//{
//    if (item == '(' || item == '{' || item == '[')
//        stack.Push(item);
//    else
//    {
//        if (stack.Count == 0)
//            return false;
//        var res = stack.Pop();
//        if (item == ')' && res != '(' ||
//            item == ']' && res != '[' ||
//            item == '}' && res != '{')
//            return false;
//    }
//}

//return stack.Count == 0;
//}
//Console.WriteLine(IsValid("()"));
//Console.WriteLine(IsValid("()[]{}"));
//Console.WriteLine(IsValid("(]"));
//Console.WriteLine(IsValid("([)]"));
//Console.WriteLine(IsValid("(("));
//Console.WriteLine(IsValid("(){}}{"));







#endregion

#region Task 3
//public class ListNode
//{
//    public int val;
//    public ListNode next;
//    public ListNode(int val = 0, ListNode next = null)
//    {
//        this.val = val;
//        this.next = next;
//    }
//}
//list1 = [1, 2, 4], list2 = [1, 3, 4]
//ListNode MergeTwoLists(ListNode list1, ListNode list2)
//{
//    ListNode dummyHead = new ListNode(-1);
//    // Create a dummy node as the starting point
//    ListNode current = dummyHead;
//    // Pointer to keep track of the current node

//    while (list1 != null && list2 != null)
//    {
//        if (list1.val <= list2.val)
//        {
//            current.next = list1;
//            list1 = list1.next;
//        }
//        else
//        {
//            current.next = list2;
//            list2 = list2.next;
//        }
//        current = current.next;
//    }

//    // Attach the remaining nodes if any
//    if (list1 != null)
//    {
//        current.next = list1;
//    }
//    else
//    {
//        current.next = list2;
//    }

//    return dummyHead.next;
//}
//}
//List<ListNode> list1 = new List<ListNode> { 1, 2, 4 };
//MergeTwoLists(list1, list2);
#endregion