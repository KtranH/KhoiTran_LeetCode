using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Sum
{
    internal class Solution
    {
        public IList<IList<int>> solve_3Sum(int[] nums) {
            int n = nums.Length;
            IList<IList<int>> result = new List<IList<int>>();
            nums = nums.OrderBy(x => x).ToArray();
            for (int i = 0; i < n; i++) {
                if (i > 0 && nums[i] == nums[i - 1]) continue; 
                int left = i + 1, right = n - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1]) left++; 
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    } else if (sum < 0)
                    {
                        left++;
                    } else
                    {
                        right--;
                    }
                }
            }
            return result;
        }
    }
}
