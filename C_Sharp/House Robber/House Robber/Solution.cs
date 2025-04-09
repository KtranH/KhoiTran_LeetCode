using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Robber
{
    internal class Solution
    {
        public int solve_house_robber(int[] nums)
        {
            int prev2 = 0;
            int prev1 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int curr = Math.Max(prev1, prev2 + nums[i]);
                prev2 = prev1;
                prev1 = curr;
            }

            return prev1;
        }
    }
}
