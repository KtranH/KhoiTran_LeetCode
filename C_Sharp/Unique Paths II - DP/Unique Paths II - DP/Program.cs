using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

//Example 1:


//Input: obstacleGrid = [[0, 0, 0], [0, 1, 0], [0, 0, 0]]
//Output: 2
//Explanation: There is one obstacle in the middle of the 3x3 grid above.
//There are two ways to reach the bottom-right corner:
//1.Right->Right->Down->Down
//2.Down->Down->Right->Right
//Example 2:


//Input: obstacleGrid = [[0, 1], [0, 0]]
//Output: 1

namespace Unique_Paths_II___DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] obstacleGrid = new int[][]
            {
                new int[] {0,0,0},
                new int[] {0,1,0},
                new int[] {0,0,0}
            };

            Solution solution = new Solution();
            int result = solution.solve_unique_paths_ii(obstacleGrid);
            Console.WriteLine(result); // Output: 2
            Console.ReadLine();
        }
    }
}
