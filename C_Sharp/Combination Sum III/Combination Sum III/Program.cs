//Example 1:

//Input: k = 3, n = 7
//Output: [[1,2,4]]
//Explanation:
//1 + 2 + 4 = 7
//There are no other valid combinations.
//Example 2:

//Input: k = 3, n = 9
//Output: [[1,2,6],[1,3,5],[2,3,4]]
//Explanation:
//1 + 2 + 6 = 9
//1 + 3 + 5 = 9
//2 + 3 + 4 = 9
//There are no other valid combinations.
//Example 3:

//Input: k = 4, n = 1
//Output: []
//Explanation: There are no valid combinations.
//Using 4 different numbers in the range [1,9], the smallest sum we can get is 1+2+3+4 = 10 and since 10 > 1, there are no valid combination.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination_Sum_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int k = 3;
            int n = 7;
            IList<IList<int>> result = solution.solve_combination_sum_iii(k, n);
            foreach (var combination in result)
            {
                Console.WriteLine(string.Join(", ", combination));
            }
        }
    }
}
