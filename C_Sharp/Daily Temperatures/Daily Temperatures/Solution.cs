using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Temperatures
{
    internal class Solution
    {
        public int[] solve_daily_temperatures(int[] temperatures) {
            int n = temperatures.Length;
            int[] result = new int[n];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++) {
                while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) {
                    int index = stack.Pop();
                    result[index] = i - index;
                }
                stack.Push(i);
            }
            return result;
        }
    }
}
