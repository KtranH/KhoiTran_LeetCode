using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Triplet_Subsequence
{
    public class Solution
    {
        public bool slove_increasing_triplet_subsequence(int[] nums)
        {
            int max_muns_first = nums.Max() + 1;
            int max_muns_second = nums.Max() + 1;
            foreach (int num in nums)
            {
                if (num <= max_muns_first)
                {
                    max_muns_first = num;
                }
                else if (num <= max_muns_second)
                {
                    max_muns_second = num;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
