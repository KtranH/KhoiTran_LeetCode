using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Prefix
{
    internal class Solution
    {
        public string solve_longest_common_prefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";
            for(int i = 0; i < strs[0].Length; i++)
            {
                char prefix = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != prefix)
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }
            return strs[0];
        }
    }
}
