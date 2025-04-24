using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: intervals = [[1, 2], [2, 3], [3, 4], [1, 3]]
//Output: 1
//Explanation: [1,3] can be removed and the rest of the intervals are non-overlapping.
//Example 2:

//Input: intervals = [[1, 2], [1, 2], [1, 2]]
//Output: 2
//Explanation: You need to remove two [1,2] to make the rest of the intervals non-overlapping.
//Example 3:

//Input: intervals = [[1, 2], [2, 3]]
//Output: 0
//Explanation: You don't need to remove any of the intervals since they're already non-overlapping.

namespace Non_overlapping_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] intervals = new int[][]
            {
                new int[] {1, 2},
                new int[] {2, 3},
                new int[] {3, 4},
                new int[] {1, 3}
            };

            Solution solution = new Solution();
            int result = solution.solve_non_overlapping_intervals(intervals);
            Console.WriteLine(result); // Output: 1
            Console.ReadLine();
        }
    }
}
