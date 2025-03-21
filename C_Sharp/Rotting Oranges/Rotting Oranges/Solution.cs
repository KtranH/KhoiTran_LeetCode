using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Rotting_Oranges
{
    internal class Solution
    {
        public int BFS(int[][] grid) {
            int count_fresh = 0;
            Queue<(int, int, int )> queue = new Queue<(int, int, int)>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 2)
                        queue.Enqueue((i, j, 0));
                    else if (grid[i][j] == 1)
                        count_fresh++;
                }
            }
            if (count_fresh == 0)
                return 0;
            while(queue.Count != 0)
            {
                var (x, y, time) = queue.Dequeue();
                foreach((int dx, int dy) in new List<(int, int)> { (-1, 0), (1, 0), (0, -1), (0, 1) })
                {
                    int nx = x + dx, ny = y + dy;
                    if(nx >= 0 && nx < grid.Length && ny >= 0 && ny < grid[0].Length && grid[nx][ny] == 1)
                    {
                        grid[nx][ny] = 2;
                        queue.Enqueue((nx, ny, time + 1));
                        count_fresh--;
                    }
                }
                if(count_fresh == 0)
                    return time + 1;
            }    
            return -1; 
        }
        public int solve_rotting_oranges()
        {
            int[][] grid = new int[][] { new int[] { 2, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 0, 1, 1 } };
            return BFS(grid);
        }
    }
}
