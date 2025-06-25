using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:


//Input: board = [[0, 1, 0], [0, 0, 1], [1, 1, 1], [0, 0, 0]]
//Output: [[0,0,0],[1,0,1],[0,1,1],[0,1,0]]
//Example 2:


//Input: board = [[1, 1], [1, 0]]
//Output: [[1,1],[1,1]]

namespace Game_of_Life
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] board = new int[][]
            {
                new int[] { 0, 1, 0 },
                new int[] { 0, 0, 1 },
                new int[] { 1, 1, 1 },
                new int[] { 0, 0, 0 }
            };

            solution.solve_game_of_life(board);

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    Console.Write(board[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
