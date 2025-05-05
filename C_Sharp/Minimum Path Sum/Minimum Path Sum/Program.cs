using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:


//Input: grid = [[1, 3, 1], [1, 5, 1], [4, 2, 1]]
//Output: 7
//Explanation: Because the path 1 → 3 → 1 → 1 → 1 minimizes the sum.
//Example 2:

//Input: grid = [[1, 2, 3], [4, 5, 6]]
//Output: 12

namespace Minimum_Path_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[][]
            {
                new int[] { 1, 3, 1 },
                new int[] { 1, 5, 1 },
                new int[] { 4, 2, 1 }
            };

            Solution solution = new Solution();
            int result = solution.solve_minimum_path_sum(grid);
            Console.WriteLine(result); // Output: 7
            Console.ReadLine();
        }
    }
}
