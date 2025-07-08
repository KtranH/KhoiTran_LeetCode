using System;
using System.Collections.Generic;
/*
Example 1:

Input: nums = [100,4,200,1,3,2]
Output: 4
Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
Example 2:

Input: nums = [0,3,7,2,5,8,4,6,0,1]
Output: 9
Example 3:

Input: nums = [1,0,1,2]
Output: 3*/

namespace LongestConsecutiveSequence
{
    class Program
    {
        public static int solve_longest_consecutive_sequence(int[] nums)
        {
            HashSet<int> hash_set = new HashSet<int>(nums);
            int longest_streak = 0;
            foreach (int num in hash_set)
            {
                if (!hash_set.Contains(num - 1))
                {
                    int current_num = num;
                    int current_streak = 1;
                    while (hash_set.Contains(current_num + 1))
                    {
                        current_num += 1;
                        current_streak += 1;
                    }
                    longest_streak = Math.Max(longest_streak, current_streak);
                }
            }
            return longest_streak;
        }
        public static void Main(string[] args)
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };
            Console.WriteLine(solve_longest_consecutive_sequence(nums));
            Console.ReadKey();
        }
    }
}