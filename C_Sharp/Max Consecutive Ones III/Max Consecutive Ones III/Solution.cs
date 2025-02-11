using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Max_Consecutive_Ones_III
{
    public class Solution
    {
        public int solve_max_consecutive_ones_iii(int[] nums, int k)
        {
            int left_index = 0;
            int zero_count = 0;
            int max_length = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) {
                    zero_count++;
                }
                if (zero_count > k){
                    if (nums[left_index] == 0)
                    {
                        zero_count--;
                    }
                    left_index++;
                }
                int sliding_window = i - left_index + 1;
                if(max_length < sliding_window) max_length = sliding_window;
            }
            return max_length;
        }
    }
}
