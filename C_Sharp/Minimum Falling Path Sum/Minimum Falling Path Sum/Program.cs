using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:


//Input: matrix = [[2, 1, 3], [6, 5, 4], [7, 8, 9]]
//Output: 13
//Explanation: There are two falling paths with a minimum sum as shown.
//Example 2:


//Input: matrix = [[-19, 57], [-40, -5]]
//Output: -59
//Explanation: The falling path with a minimum sum is shown.

namespace Minimum_Falling_Path_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] matrix = new int[][]
            {
                new int[] { 2, 1, 3 },
                new int[] { 6, 5, 4 },
                new int[] { 7, 8, 9 }
            };
            Console.WriteLine(solution.solve_min_falling_path_sum(matrix));
            Console.ReadKey();
        }
    }
}
