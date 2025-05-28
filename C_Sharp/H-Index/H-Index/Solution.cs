using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Index
{
    internal class Solution
    {
        public int solve_h_index(int[] citations)
        {
            Array.Sort(citations);
            Array.Reverse(citations);
            int h = 0;
            for (int i = 0; i < citations.Length; i++)
            {
                if (citations[i] >= i + 1)
                {
                    h = i + 1;
                }
                else
                {
                    break;
                }
            }
            return h; 
        }
    }
}
