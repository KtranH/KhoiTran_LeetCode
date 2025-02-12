using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Subarray_of_1_s_After_Deleting_One_Element
{
    public class Solution
    {
        public int soved_solve_longest_subarray_of_1s_after_deleting_one_element(int[] nums)
        {
            int left = 0;
            int zero = 0;
            int max_length = 0;

            for(int right = 0; right < nums.Length; right++) {
                if (nums[right] == 0) zero++;

                while (zero > 1) {
                    if (nums[left] == 0) zero--;
                    left++;
                }

                int temp = right - left;
                if (temp > max_length) max_length = temp;
            }
            return max_length;
        }
    }
}
