//Example 1:


//Input: n = 6, connections = [[0, 1], [1, 3], [2, 3], [4, 0], [4, 5]]
//Output: 3
//Explanation: Change the direction of edges show in red such that each node can reach the node 0 (capital).
//Example 2:


//Input: n = 5, connections = [[1, 0], [1, 2], [3, 2], [3, 4]]
//Output: 2
//Explanation: Change the direction of edges show in red such that each node can reach the node 0 (capital).
//Example 3:

//Input: n = 3, connections = [[1, 0], [2, 0]]
//Output: 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reorder_Routes_to_Make_All_Paths_Lead_to_the_City_Zero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_reorder_routes());
            Console.ReadKey();
        }
    }
}
