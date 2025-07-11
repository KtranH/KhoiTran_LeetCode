using System;
using System.Collections.Generic;

/*
Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
*/

namespace InsertInterval
{
    class Program
    {
        static int[][] solve_insert_interval(int[][] intervals, int[] newInterval)
        {
            List<int[]> result = new List<int[]>();
            intervals = intervals.Append(newInterval).ToArray();
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            int n = intervals.Length;
            int[] current = intervals[0];
            for(int i = 1; i < n; i++)
            {
                if(intervals[i][0] <= current[1])
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
            int[][] intervals = { { 1, 2 }, { 3, 5 }, { 6, 7 }, { 8, 10 }, { 12, 16 } };
            int[] newInterval = { 4, 8 };
            int[][] result = solve_insert_interval(intervals, newInterval);
            foreach (int[] interval in result)
            {
                Console.WriteLine($"[{interval[0]}, {interval[1]}");
            }
            Console.ReadKey();
        }
    }
}