using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Stock_Span
{
    internal class Solution
    {
        Stack<int[]> stack = new Stack<int[]>();
        public Solution()
        {
            this.stack = new Stack<int[]>();
        }

        public int Next(int price)
        {
            int count = 1;
            while (stack.Count > 0 && stack.Peek()[0] <= price)
            {
                count += stack.Pop()[1];
            }
            stack.Push(new int[] { price, count });
            return count;
        }
    }
}
