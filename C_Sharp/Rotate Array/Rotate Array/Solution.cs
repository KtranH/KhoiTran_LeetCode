using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Array
{
    internal class Solution
    {
        public void solve_rotate_array(int[] nums, int k)
        {
            int right = k % nums.Length;
            int n = nums.Length;
            int[] temp = (int[])nums.Clone();
            for (int i = 0; i < n; i++)
            {
                nums[i] = temp[(i - right + n) % n];
            }
        }
    }
}
