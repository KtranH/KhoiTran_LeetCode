using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_Square
{
    internal class Solution
    {
        public int solve_maximal_square(char[][] matrix) {
            int n = matrix.Length;
            int m = matrix[0].Length;
            int[][] dp = new int[n + 1][];
            for (int i = 0; i <= n; i++)
            {
                dp[i] = new int[m + 1];
            }
            int res = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (matrix[i - 1][j - 1] == '1')
                    {
                        dp[i][j] = Math.Min(dp[i - 1][j], Math.Min(dp[i - 1][j - 1], dp[i][j - 1])) + 1;
                        res = Math.Max(res, dp[i][j]);
                    }
                }
            }
            return res * res;
        }
    }
}
