using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Path_Sum
{
    internal class Solution
    {
        public int solve_minimum_path_sum(int[][] grid)
        {
            int[][] dp = new int[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                dp[i] = new int[grid[0].Length];
            }
            dp[0][0] = grid[0][0];
            for (int i = 1; i < grid.Length; i++)
            {
                dp[i][0] = dp[i - 1][0] + grid[i][0];
            }
            for (int i = 1; i < grid[0].Length; i++)
            {
                dp[0][i] = dp[0][i - 1] + grid[0][i];
            }
            for (int i = 1; i < grid.Length; i++)
            {
                for (int j = 1; j < grid[0].Length; j++)
                {
                    dp[i][j] = Math.Min(dp[i - 1][j], dp[i][j - 1]) + grid[i][j];
                }
            }
            return dp[grid.Length - 1][grid[0].Length - 1];
        }
    }
}
