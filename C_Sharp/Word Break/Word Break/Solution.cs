using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Break
{
    internal class Solution
    {
        public bool solve_word_break(string s, IList<string> wordDict) { 
           int n = s.Length;
           bool[] dp = new bool[n + 1];
           dp[0] = true;
           for(int i = 1; i <= n; i++) {
               for (int j = 0; j < i; j++) {
                   if (dp[j] && wordDict.Contains(s.Substring(j, i - j))) {
                       dp[i] = true;
                       break;
                   }
               }
           }
           return dp[n];
        }
    }
}
