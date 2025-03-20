/*Example 1:


Input: maze = [["+", "+", ".", "+"], [".", ".", ".", "+"], ["+", "+", "+", "."]], entrance = [1, 2]
Output: 1
Explanation: There are 3 exits in this maze at [1,0], [0,2], and[2, 3].
Initially, you are at the entrance cell [1, 2].
- You can reach[1, 0] by moving 2 steps left.
- You can reach [0,2] by moving 1 step up.
It is impossible to reach [2,3] from the entrance.
Thus, the nearest exit is [0,2], which is 1 step away.
Example 2:


Input: maze = [["+", "+", "+"], [".", ".", "."], ["+", "+", "+"]], entrance = [1, 0]
Output: 2
Explanation: There is 1 exit in this maze at [1, 2].
[1, 0] does not count as an exit since it is the entrance cell.
Initially, you are at the entrance cell [1, 0].
- You can reach[1, 2] by moving 2 steps right.
Thus, the nearest exit is [1,2], which is 2 steps away.
Example 3:


Input: maze = [[".", "+"]], entrance = [0, 0]
Output: -1
Explanation: There are no exits in this maze.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nearest_Exit_from_Entrance_in_Maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_nearest_exit());
            Console.ReadKey();
        }
    }
}
