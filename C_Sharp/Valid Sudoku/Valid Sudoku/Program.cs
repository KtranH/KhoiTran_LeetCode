﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Input: board =
//[["5", "3", ".", ".", "7", ".", ".", ".", "."]
//,
//["6", ".", ".", "1", "9", "5", ".", ".", "."]
//,
//[".", "9", "8", ".", ".", ".", ".", "6", "."]
//,
//["8", ".", ".", ".", "6", ".", ".", ".", "3"]
//,
//["4", ".", ".", "8", ".", "3", ".", ".", "1"]
//,
//["7", ".", ".", ".", "2", ".", ".", ".", "6"]
//,
//[".", "6", ".", ".", ".", ".", "2", "8", "."]
//,
//[".", ".", ".", "4", "1", "9", ".", ".", "5"]
//,
//[".", ".", ".", ".", "8", ".", ".", "7", "9"]]
//Output: true
//Example 2:

//Input: board =
//[["8", "3", ".", ".", "7", ".", ".", ".", "."]
//,
//    ["6", ".", ".", "1", "9", "5", ".", ".", "."]
//,
//    [".", "9", "8", ".", ".", ".", ".", "6", "."]
//,
//    ["8", ".", ".", ".", "6", ".", ".", ".", "3"]
//,
//    ["4", ".", ".", "8", ".", "3", ".", ".", "1"]
//,
//    ["7", ".", ".", ".", "2", ".", ".", ".", "6"]
//,
//    [".", "6", ".", ".", ".", ".", "2", "8", "."]
//,
//    [".", ".", ".", "4", "1", "9", ".", ".", "5"]
//,
//    [".", ".", ".", ".", "8", ".", ".", "7", "9"]]
//Output: false
//Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.

namespace Valid_Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            char[][] board = new char[][]
            {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '9', '.', '.', '5', '.', '7', '.' },
                new char[] { '7', '.', '.', '2', '.', '3', '.', '.', '1' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };
            Console.WriteLine(solution.solve_valid_sudoku(board));
            Console.ReadLine();
        }
    }
}
