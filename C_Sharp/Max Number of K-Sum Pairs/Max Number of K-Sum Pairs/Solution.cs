using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number_of_K_Sum_Pairs
{
    public class Solution
    {
        public int solve_max_number_of_k_sum_pairs(int[] nums, int k) {
            int count = 0;
            int left_index = 0;
            int right_index = nums.Length - 1;
            Array.Sort(nums);
            while (left_index < right_index)
            {
                int sum = nums[left_index] + nums[right_index];
                if (sum == k)
                {
                    left_index++;
                    right_index--;
                    count++;
                }
                else
                {
                    if (sum < k)
                    {
                        left_index++;
                    }
                    else
                    {
                        right_index--;
                    }
                }
            }
            return count;
        }
    }
}
