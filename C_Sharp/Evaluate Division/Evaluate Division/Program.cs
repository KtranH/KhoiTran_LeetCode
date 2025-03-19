//Example 1:

//Input: equations = [["a", "b"], ["b", "c"]], values = [2.0, 3.0], queries = [["a", "c"], ["b", "a"], ["a", "e"], ["a", "a"], ["x", "x"]]
//Output: [6.00000,0.50000,-1.00000,1.00000,-1.00000]
//Explanation:
//Given: a / b = 2.0, b / c = 3.0
//queries are: a / c = ?, b / a = ?, a / e = ?, a / a = ?, x / x = ?
//return: [6.0, 0.5, -1.0, 1.0, -1.0 ]
//note: x is undefined => -1.0
//Example 2:

//Input: equations = [["a", "b"], ["b", "c"], ["bc", "cd"]], values = [1.5, 2.5, 5.0], queries = [["a", "c"], ["c", "b"], ["bc", "cd"], ["cd", "bc"]]
//Output: [3.75000,0.40000,5.00000,0.20000]

//[1,0] does not count as an exit since it is the entrance cell.
//Initially, you are at the entrance cell [1, 0].
//- You can reach[1, 2] by moving 2 steps right.
//Thus, the nearest exit is [1,2], which is 2 steps away.
//Example 3:

//Input: equations = [["a", "b"]], values = [0.5], queries = [["a", "b"], ["b", "a"], ["a", "c"], ["x", "y"]]
//Output: [0.50000,2.00000,-1.00000,-1.00000]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluate_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_evaluate_division());
            Console.ReadKey();
        }
    }
}
