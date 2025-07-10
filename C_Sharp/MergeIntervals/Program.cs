using System;
using System.Collections;
using System.Collections.Generic;
namespace MergeIntervals
{
    class Program
    {
        public int[][] solve_merge_intervals(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            int n = intervals.Length;
            List<int[]> result = new List<int[]>();
            int[] current = intervals[0];

            for (int i = 1; i < n; i++)
            {
                if (intervals[i][0] <= current[1])
                {
                    current[1] = Math.Max(current[1], intervals[i][1]);
                }
                else
                {
                    result.Add(current);
                    current = intervals[i];
                }
            }

            result.Add(current);
            return result.ToArray();
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] intervals = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 2, 6 },
                new int[] { 8, 10 },
                new int[] { 15, 18 }
            };
            int[][] result = solution.solve_merge_intervals(intervals);
            foreach (int[] interval in result)
            {
                Console.WriteLine($"[{interval[0]}, {interval[1]}");
            }
            Console.ReadKey();
        }
    }
}