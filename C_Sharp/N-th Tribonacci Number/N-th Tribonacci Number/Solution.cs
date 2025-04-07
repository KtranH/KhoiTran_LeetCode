using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_th_Tribonacci_Number
{
    internal class Solution
    {
        public int solve_n_th_tribonacci_number(int n)
        {
            if(n == 0) return 0;
            else if(n == 1 || n == 2) return 1;

            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 1;

            for(int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
            }
            return dp[n];
        }
    }
}
