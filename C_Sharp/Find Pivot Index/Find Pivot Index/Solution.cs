using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Pivot_Index
{
    public class Solution
    {
        public int solve_find_pivot_index(int[] nums)
        {
            int total_sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                total_sum += nums[i];
            }

            int left_sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(left_sum == total_sum - left_sum - nums[i])
                {
                    return i;
                }
                left_sum += nums[i];
            }
            return -1;
        }
    }
}
