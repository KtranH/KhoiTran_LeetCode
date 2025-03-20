using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nearest_Exit_from_Entrance_in_Maze
{
    internal class Solution
    {
        public int BFS(char[][] maze, int[] entrance, HashSet<(int, int)> visited)
        {
            Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
            queue.Enqueue((entrance[0], entrance[1], 0));
            visited.Add((entrance[0], entrance[1]));
            while (queue.Count > 0)
            {
                (int x, int y, int dist) = queue.Dequeue();
                if ((x == 0 || x == maze.Length - 1 || y == 0 || y == maze[0].Length - 1) && ((x, y) != (entrance[0], entrance[1])))
                {
                    return dist;
                }
                foreach((int dx, int dy) in new (int, int)[] { (-1, 0), (1, 0), (0, -1), (0, 1) })
                {
                    int nx = x + dx, ny = y + dy;
                    if(0 <= nx && nx < maze.Length && 0 <= ny && ny < maze[0].Length && maze[nx][ny] == '.' && !visited.Contains((nx, ny)))
                    {
                        visited.Add((nx, ny));
                        queue.Enqueue((nx, ny, dist + 1));
                    }    
                }    
            }    
            return -1;
        }
        public int solve_nearest_exit()
        {
            char[][] maze = new char[][] { new char[] { '+', '+', '+', '+' }, new char[] { '+', '.', '.', '+' }, new char[] { '+', '+', '+', '+' } };
            int[] entrance = new int[] { 1, 2 };
            HashSet<(int, int)> visited = new HashSet<(int, int)>();
            return BFS(maze, entrance, visited);
        }
    }
}
