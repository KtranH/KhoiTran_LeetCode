using System;
using System.Collections.Generic;

/*
Example 1:

Input: val = -2
Output: None
Explanation: The minimum stack is initialized with the value -2.
Example 2:

Input: val = 0
Output: None
Explanation: The minimum stack is initialized with the value 0.
Example 3:

Input: val = -3
Output: None
Explanation: The minimum stack is initialized with the value -3.
*/

namespace MinStack
{
    class MinStack
    {
        private Stack<int> stack;
        private Stack<int> minStack;
        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }
        public void Push(int val)
        {
            stack.Push(val);
            if (minStack.Count == 0 || val <= minStack.Peek())
            {
                minStack.Push(val);
            }
        }
        public void Pop()
        {
            if (stack.Count > 0)
            {
                int val = stack.Pop();
                if (val == minStack.Peek())
                {
                    minStack.Pop();
                }
            }
        }
        public int Top()
        {
            return stack.Peek();
        }
        public int GetMin()
        {
            return minStack.Peek();
        }   
    }
    class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Console.WriteLine(minStack.GetMin());
            minStack.Pop();
            Console.WriteLine(minStack.Top());
            Console.WriteLine(minStack.GetMin());
        }
    }
}
