using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majority_Element
{
    internal class Solution
    {
        public int solve_majority_element(int[] nums)
        {
            int count = 0;
            int candidate = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                }
                if (nums[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return candidate;   
        }
    }
}
