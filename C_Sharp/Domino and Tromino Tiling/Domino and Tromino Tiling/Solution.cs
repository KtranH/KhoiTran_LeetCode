using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino_and_Tromino_Tiling
{
    internal class Solution
    {
        public int solve_domino_and_tromino_tiling(int n)
        {
            if (n == 1) return 1;
            else if (n == 2) return 2;
            else if (n == 0) return 1;

            long MOD = 1000000007;

            long[] dp = new long[n + 1];
            dp[0] = 1;
            dp[1] = 1;
            dp[2] = 2;
            long sum_dp = 1;

            for (int i = 3; i <= n; i++)
            {
                dp[i] = (dp[i - 1] + dp[i - 2] + 2 * sum_dp) % MOD;
                sum_dp = (sum_dp + dp[i - 2]) % MOD;
            }
            return (int)dp[n];
        }
    }
}
