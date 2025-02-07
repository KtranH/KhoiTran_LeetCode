using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container_With_Most_Water
{
    public class Solution
    {
        public int solve_container_with_most_water(int[] height) {
            int left_index = 0;
            int right_index = height.Length - 1;
            int max_water = 0;
            while (left_index < right_index) {
                int temp = Math.Min(height[left_index], height[right_index]) * (right_index - left_index);
                max_water = Math.Max(max_water, temp);
                if (height[left_index] < height[right_index]) {
                    left_index++;
                } else {
                    right_index--;
                }
            }
            return max_water;
        }
    }
}
