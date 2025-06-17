using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Sudoku
{
    internal class Solution
    {
        public bool solve_valid_sudoku(char[][] board) {
            HashSet<char>[] rows = new HashSet<char>[9];
            HashSet<char>[] cols = new HashSet<char>[9];
            HashSet<char>[] boxes = new HashSet<char>[9];

            for (int i = 0; i < 9; i++)
            {
                rows[i] = new HashSet<char>();
                cols[i] = new HashSet<char>();
                boxes[i] = new HashSet<char>();
            }

            for(int i = 0; i < 9; i++) 
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.') continue;
                    int box = i / 3 * 3 + j / 3;
                    if (rows[i].Contains(board[i][j]) || cols[j].Contains(board[i][j]) || boxes[box].Contains(board[i][j])) return false;

                    rows[i].Add(board[i][j]);
                    cols[j].Add(board[i][j]);
                    boxes[box].Add(board[i][j]);
                 
                }
            }
            return true;
        }
    }
}
