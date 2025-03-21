

/*Example 1:


Input: grid = [[2, 1, 1], [1, 1, 0], [0, 1, 1]]
Output: 4
Example 2:

Input: grid = [[2, 1, 1], [0, 1, 1], [1, 0, 1]]
Output: -1
Explanation: The orange in the bottom left corner (row 2, column 0) is never rotten, because rotting only happens 4-directionally.
Example 3:

Input: grid = [[0, 2]]
Output: 0
Explanation: Since there are already no fresh oranges at minute 0, the answer is just 0.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotting_Oranges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_rotting_oranges().ToString());
            Console.ReadKey();
        }
    }
}
