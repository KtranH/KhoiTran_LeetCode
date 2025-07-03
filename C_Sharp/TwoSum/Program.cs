
using System;
using System.Collections.Generic;


/*Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]*/

namespace TwoSum
{
    class TwoSum
    {
        public int[] solve_two_sum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }
            return new int[] { };
        }
        public static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum twoSum = new TwoSum();
            int[] result = twoSum.solve_two_sum(nums, target);
            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}