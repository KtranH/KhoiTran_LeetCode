using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Zeroes
{
    public class Solution
    {
        public void solve_move_zeroes(List<int> nums)
        {
            int not_zero_index = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] != 0)
                {
                    nums[not_zero_index] = nums[i];
                    not_zero_index++;
                }
            }
            for(int i = not_zero_index; i < nums.Count; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
