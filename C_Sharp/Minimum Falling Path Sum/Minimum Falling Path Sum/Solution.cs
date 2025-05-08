using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Falling_Path_Sum
{
    internal class Solution
    {
        public int solve_min_falling_path_sum(int[][] matrix) {
            int n = matrix.Length;
            int[][] dp = matrix;
            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if(j == 0)
                    {
                        dp[i][j] += Math.Min(dp[i + 1][j], dp[i + 1][j + 1]);
                    }
                    else if (j == n - 1)
                    {
                        dp[i][j] += Math.Min(dp[i + 1][j - 1], dp[i + 1][j]);
                    }
                    else
                    {
                        dp[i][j] += Math.Min(dp[i + 1][j - 1], Math.Min(dp[i + 1][j], dp[i + 1][j + 1]));
                    }
                }
            }
            return dp[0].Min();
        }
    }
}
