//Example 1:


//Input: root = [10, 5, -3, 3, 2, null, 11, 3, -2, null, 1], targetSum = 8
//Output: 3
//Explanation: The paths that sum to 8 are shown.
//Example 2:

//Input: root = [5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1], targetSum = 22
//Output: 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_Sum_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Node root = solution.insert_level_order(new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1 });
            Console.WriteLine(solution.solve_path_sum_iii(root, 22));
            Console.ReadKey();
        }
    }
}
