//Example 1:

//Input: nums = [1, 2, 3, 4], k = 5
//Output: 2
//Explanation: Starting with nums = [1, 2, 3, 4]:
//-Remove numbers 1 and 4, then nums = [2, 3]
//- Remove numbers 2 and 3, then nums = []
//There are no more pairs that sum up to 5, hence a total of 2 operations.
//Example 2:

//Input: nums = [3, 1, 3, 4, 3], k = 6
//Output: 1
//Explanation: Starting with nums = [3, 1, 3, 4, 3]:
//-Remove the first two 3's, then nums = [1,4,3]
//There are no more pairs that sum up to 6, hence a total of 1 operation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number_of_K_Sum_Pairs
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 4, 1, 3, 1, 3, 2, 2, 5, 5, 1, 5, 2, 1, 2, 3, 5, 4 };
            int k = 2;
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_max_number_of_k_sum_pairs(nums, k));
            Console.ReadKey();
        }
    }
}
