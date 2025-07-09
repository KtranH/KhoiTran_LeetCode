using System;
using System.Collections;
using System.Collections.Generic;

/*
Example 1:

Input: nums = [0,2,3,4,6,8,9]
Output: ["0","2->4","6","8->9"]
Explanation: The ranges are:
[0,0] --> "0"
[2,4] --> "2->4"
[6,6] --> "6"
[8,9] --> "8->9"
Example 2:

Input: nums = [0,1,2,4,5,7]
Output: ["0->2","4->5","7"]
Explanation: The ranges are:
[0,2] --> "0->2"
[4,5] --> "4->5"
[7,7] --> "7"
*/

namespace SummaryRanges
{
    class Program
    {
        static IList<string> solve_summary_ranges(int[] nums)
        {
            IList<string> result = new List<string>();
            int n = nums.Length;
            if (n == 0) return result;
            int start = nums[0];
            for (int i = 1; i < n; i++)
            {
                if(nums[i] != nums[i - 1] + 1)
                {
                    int end = nums[i - 1];
                    if(start == end)
                    {
                        result.Add(start.ToString());
                    }
                    else
                    {
                        result.Add(start.ToString() + "->" + end.ToString());
                    }
                    start = nums[i];
                }
            }
            if(start == nums[n - 1])
            {
                result.Add(start.ToString());
            }
            else
            {
                result.Add(start.ToString() + "->" + nums[n - 1].ToString());
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] nums = { 0, 2, 3, 4, 6, 8, 9 };
            IList<string> result = solve_summary_ranges(nums);
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}