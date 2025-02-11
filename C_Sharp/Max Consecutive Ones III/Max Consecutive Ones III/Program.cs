//Example 1:

//Input: nums = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], k = 2
//Output: 6
//Explanation: [1,1,1,0,0,1,1,1,1,1,1]
//Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.
//Example 2:

//Input: nums = [0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1], k = 3
//Output: 10
//Explanation: [0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1]
//Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Consecutive_Ones_III
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{ 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
            int k = 3;

            Solution solution = new Solution();
            Console.WriteLine(solution.solve_max_consecutive_ones_iii(nums, k));
            Console.ReadKey();
        }
    }
}
