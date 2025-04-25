using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Number_of_Arrows_to_Burst_Balloons
{
    internal class Solution
    {
        public int solve_min_number_of_arrows_to_burst_balloons(int[][] points)
        {
            Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));
            int count = 1;
            long end = points[0][1];
            for(int i = 0; i < points.Length; i++)
            {
                if (points[i][0] > end)
                {
                    count++;
                    end = points[i][1];
                }
            }    
            return count;
        }
    }
}
