using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Example 1:

Input: tokens = ["2","1","+","3","*"]
Output: 9
Explanation: ((2 + 1) * 3) = 9
Example 2:

Input: tokens = ["4","13","5","/","+"]
Output: 6
Explanation: (4 + (13 / 5)) = 6
Example 3:

Input: tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]
Output: 22
*/

namespace ReversePolishNotation
{
    class Program
    {
        static int solve_ReversePolishNotation(string[] tokens) {
            Stack<int> stack = new Stack<int>();
            foreach (string token in tokens)
            {
                if (token == "+")
                {
                    stack.Push(stack.Pop() + stack.Pop());
                }
                else if (token == "-")
                {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    stack.Push(a - b);
                }
                else if (token == "*")
                {
                    stack.Push(stack.Pop() * stack.Pop());
                }
                else if (token == "/")
                {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    stack.Push(a / b);
                }
                else
                {
                    stack.Push(int.Parse(token));
                }
            }
            return stack.Pop();
        }
        static void Main(string[] args)
        {
            int result = solve_ReversePolishNotation(new string[] { "2", "1", "+", "3", "*" });
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}