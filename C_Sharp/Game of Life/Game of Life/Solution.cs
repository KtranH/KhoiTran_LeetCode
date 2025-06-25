using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    internal class Solution
    {
        public void solve_game_of_life(int[][] board)
        {
            int n = board.Length;
            int m = board[0].Length;
            int[][] board_copy = new int[n][];
            for (int i = 0; i < n; i++)
            {
                board_copy[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    board_copy[i][j] = board[i][j];
                }
            }
            int[][] direct = new int[][] { 
                new int[] { -1, -1 }, new int[] { -1, 0 }, new int[] { -1, 1 },
                new int[] { 0, -1 },                       new int[] { 0, 1 },
                new int[] { 1, -1 }, new int[] { 1, 0 },   new int[] { 1, 1 }
            };
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int cnt = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        int x = i + direct[k][0];
                        int y = j + direct[k][1];
                        if (x >= 0 && x < n && y >= 0 && y < m && board_copy[x][y] == 1)
                            cnt++;
                    }
                    if (board_copy[i][j] == 1 && (cnt < 2 || cnt > 3))
                        board[i][j] = 0;
                    else if (board_copy[i][j] == 0 && cnt == 3)
                        board[i][j] = 1;
                }
            }
        }
    }
}
