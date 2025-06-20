using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:


//Input: matrix = [[1, 1, 1], [1, 0, 1], [1, 1, 1]]
//Output: [[1,0,1],[0,0,0],[1,0,1]]
//Example 2:


//Input: matrix = [[0, 1, 2, 0], [3, 4, 5, 2], [1, 3, 1, 5]]
//Output: [[0,0,0,0],[0,4,5,0],[0,3,1,0]]

namespace Set_Matrix_Zeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
                new int[] {1, 1, 1},
                new int[] {1, 0, 1},
                new int[] {1, 1, 1}
            };

            Solution solution = new Solution();
            solution.solve_set_matrix_zeroes(matrix);

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
