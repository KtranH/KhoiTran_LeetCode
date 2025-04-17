using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Bits
{
    internal class Solution
    {
        public int[] slove_counting_bits(int n)
        {
            int[] result = new int[n + 1];
            result[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                result[i] = result[i & (i - 1)] + 1;
            }
            return result;
        }
    }
}
