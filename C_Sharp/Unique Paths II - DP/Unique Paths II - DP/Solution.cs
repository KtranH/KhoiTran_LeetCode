using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_Paths_II___DP
{
    internal class Solution
    {
        public int solve_unique_paths_ii(int[][] obstacleGrid) {
            int n = obstacleGrid.Length;
            int m = obstacleGrid[0].Length;
            int[][] dp = new int[n][];
            for (int i = 0; i < n; i++)
            {
                dp[i] = new int[m];
            }
            dp[0][0] = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                    {
                        dp[i][j] = 0;
                    }
                    else
                    {
                        if (i > 0)
                        {
                            dp[i][j] += dp[i - 1][j];
                        }
                        if (j > 0)
                        {
                            dp[i][j] += dp[i][j - 1];
                        }
                    }
                }
            }
            return dp[n - 1][m - 1];
        }
    }
}
