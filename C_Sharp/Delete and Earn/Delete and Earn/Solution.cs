using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete_and_Earn
{
    internal class Solution
    {
        public int solve_delete_and_earn(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int maxNum = nums.Max();
            int[] points = new int[maxNum + 1];

            foreach (int num in nums)
            {
                points[num] += num;
            }
            int prev = 0, curr = 0;

            for (int i = 0; i < points.Length; i++)
            {
                int temp = curr;
                curr = Math.Max(curr, prev + points[i]);
                prev = temp;
            }

            return curr;
        }
    }
}
