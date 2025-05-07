using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Triangle
{
    internal class Solution
    {
        public int solve_triangle(IList<IList<int>> triangle) {
            IList<IList<int>> dp = triangle;
            for (int i = triangle.Count - 2; i >= 0; i--) {
                for (int j = 0; j <= i; j++) {
                    dp[i][j] += Math.Min(dp[i + 1][j], dp[i + 1][j + 1]);
                }
            }
            return dp[0][0];
        }
    }
}
