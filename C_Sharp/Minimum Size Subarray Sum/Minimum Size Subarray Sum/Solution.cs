using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Size_Subarray_Sum
{
    internal class Solution
    {
        public int solve_min_size_subarray_sum(int[] nums, int target)
        {
            int n = nums.Length;
            int left = 0, right = 0, sum = 0, min_len = int.MaxValue;
            while (right < n)
            {
                sum += nums[right];
                while (sum >= target)
                {
                    
                    int tmp = right - left + 1;
                    if(tmp < min_len) min_len = tmp;
                    sum -= nums[left];
                    left++;
                }
                right++;
            }
            return min_len == int.MaxValue ? 0 : min_len;
        }
    }
}
