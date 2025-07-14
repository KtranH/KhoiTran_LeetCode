using System;
using System.Collections.Generic;

/*
Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
*/

namespace ValidParentheses
{
    class Program
    {
        static bool solve_valid_parentheses(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0) return false;
                    char top = stack.Pop();
                    if (c == ')' && top != '(') return false;
                    if (c == ']' && top != '[') return false;
                    if (c == '}' && top != '{') return false;
                }
            }
            return stack.Count == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solve_valid_parentheses("()[]{}"));
            Console.ReadKey();
        }
    }
}