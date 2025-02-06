using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Subsequence
{
    public class Solution
    {
        public bool solve_is_subsequence(string s, string t)
        {
            if (s.Length == 0) return true;
            int checkindex = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (s[checkindex] == t[i])
                {
                    checkindex++;
                    if (checkindex == s.Length)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
