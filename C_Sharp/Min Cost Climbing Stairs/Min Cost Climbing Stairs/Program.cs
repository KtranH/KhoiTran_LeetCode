//Example 1:

//Input: cost = [10, 15, 20]
//Output: 15
//Explanation: You will start at index 1.
//- Pay 15 and climb two steps to reach the top.
//The total cost is 15.
//Example 2:

//Input: cost = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1]
//Output: 6
//Explanation: You will start at index 0.
//- Pay 1 and climb two steps to reach index 2.
//- Pay 1 and climb two steps to reach index 4.
//- Pay 1 and climb two steps to reach index 6.
//- Pay 1 and climb one step to reach index 7.
//- Pay 1 and climb two steps to reach index 9.
//- Pay 1 and climb one step to reach the top.
//The total cost is 6.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Cost_Climbing_Stairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cost = { 10, 15, 20 };
            Solution solution = new Solution();
            int result = solution.solve_min_cost_climbing_stairs(cost);
            Console.WriteLine(result); 
            Console.ReadLine();
        }
    }
}
