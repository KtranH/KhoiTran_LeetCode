using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_overlapping_Intervals
{
    internal class Solution
    {
        public int solve_non_overlapping_intervals(int[][] intervals) {
            intervals = intervals.OrderBy(x => x[1]).ToArray();
            int count = 0;
            int end = int.MinValue;
            foreach (var interval in intervals)
            {
                if (interval[0] >= end)
                {
                    count++;
                    end = interval[1];
                }
            }
            return intervals.Length - count;
        }
    }
}
