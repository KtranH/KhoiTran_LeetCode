using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:


//Input: matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
//Output: [1,2,3,6,9,8,7,4,5]
//Example 2:


//Input: matrix = [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]]
//Output: [1,2,3,4,8,12,11,10,9,5,6,7]

namespace Spiral_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            Solution solution = new Solution();
            IList<int> result = solution.solve_spiral_matrix(matrix);

            Console.WriteLine(string.Join(", ", result));
            Console.ReadLine();
        }
    }
}
