using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Average_Subarray_I
{
    public class Solution
    {
        public double solve_maxium_average_subarray(int[] nums, int k)
        {
            double max_average = 0;
            //double max_average = nums.Take(k).Sum();
            for (int i = 0; i < k; i++)
            {
                max_average += nums[i];
            }    
            double current_average = max_average;
            for (int i = k;  i < nums.Length; i++)
            {
                current_average += nums[i] - nums[i - k];
                max_average = Math.Max(max_average, current_average);
            }    
            return Math.Round(max_average / k, 5);
        }
    }
}
