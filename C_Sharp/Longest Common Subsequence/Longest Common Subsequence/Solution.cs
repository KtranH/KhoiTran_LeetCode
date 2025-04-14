using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Subsequence
{
    internal class Solution
    {
        public int solve_longest_common_subsequence(string text1, string text2)
        {
            int[,] ints = new int[text1.Length + 1, text2.Length + 1];
            for(int i = 0; i < text1.Length; i++)
            {
                for(int j = 0; j < text2.Length; j++)
                {
                    ints[i, j] = 0;
                }    
            }    
            for(int i = 1; i < text1.Length + 1; i++)
            {
                for(int j = 1; j < text2.Length + 1; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        ints[i, j] = ints[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        ints[i, j] = Math.Max(ints[i - 1, j], ints[i, j - 1]);
                    }
                }
            }
            return ints[text1.Length, text2.Length];
        }
    }
}
