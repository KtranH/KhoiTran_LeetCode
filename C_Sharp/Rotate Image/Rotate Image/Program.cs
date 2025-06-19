using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:


//Input: matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
//Output: [[7,4,1],[8,5,2],[9,6,3]]
//Example 2:


//Input: matrix = [[5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16]]
//Output: [[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]

namespace Rotate_Image
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
            solution.solve_rotate_image(matrix);

            // Print the rotated matrix
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
