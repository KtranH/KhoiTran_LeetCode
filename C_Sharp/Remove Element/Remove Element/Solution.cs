using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Element
{
    internal class Solution
    {
        public int solve_remove_element(int[] nums, int val)
        {
            int n = nums.Length;
            int i = 0;
            for (int j = 0; j < n; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }
    }
}
