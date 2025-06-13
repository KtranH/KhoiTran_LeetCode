using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: target = 7, nums = [2, 3, 1, 2, 4, 3]
//Output: 2
//Explanation: The subarray[4, 3] has the minimal length under the problem constraint.
//Example 2:

//Input: target = 4, nums = [1, 4, 4]
//Output: 1
//Example 3:

//Input: target = 11, nums = [1, 1, 1, 1, 1, 1, 1, 1]
//Output: 0

namespace Minimum_Size_Subarray_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            int target = 7;
            Solution solution = new Solution();
            int result = solution.solve_min_size_subarray_sum(nums, target);
            Console.WriteLine(result); // Output: 2
            Console.ReadKey();
        }
    }
}
