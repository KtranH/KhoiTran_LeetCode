//Example 1:

//Input: nums = [1, 2, 3, 4, 5]
//Output: true
//Explanation: Any triplet where i<j < k is valid.
//Example 2:

//Input: nums = [5, 4, 3, 2, 1]
//Output: false
//Explanation: No triplet exists.
//Example 3:

//Input: nums = [2, 1, 5, 0, 4, 6]
//Output: true
//Explanation: The triplet(3, 4, 5) is valid because nums[3] == 0 < nums[4] == 4 < nums[5] == 6.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Triplet_Subsequence
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_increasing_triplet_subsequence(nums));
            Console.ReadKey();
        }
    }
}
