using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: triangle = [[2], [3, 4], [6, 5, 7], [4, 1, 8, 3]]
//Output: 11
//Explanation: The triangle looks like:
//   2
//  3 4
// 6 5 7
//4 1 8 3
//The minimum path sum from top to bottom is 2 + 3 + 5 + 1 = 11 (underlined above).
//Example 2:

//Input: triangle = [[-10]]
//Output: -10

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            IList<IList<int>> triangle = new List<IList<int>>
            {
                new List<int> { 2 },
                new List<int> { 3, 4 },
                new List<int> { 6, 5, 7 },
                new List<int> { 4, 1, 8, 3 }
            };

            int result = solution.solve_triangle(triangle);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
