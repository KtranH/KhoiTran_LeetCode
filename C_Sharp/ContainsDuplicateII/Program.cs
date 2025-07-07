using System;
using System.Collections.Generic;
namespace ContainsDuplicateII
{
    class Program
    {
        static void solve_contains_duplicate_ii(int[] nums, int k)
        {
            Dictionary<int, int> hash_map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hash_map.ContainsKey(nums[i]))
                {
                    if (i - hash_map[nums[i]] <= k)
                    {
                        return true;
                    }
                }
                hash_map[nums[i]] = i;
            }
            return false;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(solve_contains_duplicate_ii(new int[] { 1, 2, 3, 1 }, 3));
            Console.ReadKey();
        }
    }
}