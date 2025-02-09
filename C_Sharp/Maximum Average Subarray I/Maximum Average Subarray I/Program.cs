//Example 1:

//Input: nums = [1, 12, -5, -6, 50, 3], k = 4
//Output: 12.75000
//Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
//Example 2:

//Input: nums = [5], k = 1
//Output: 5.00000

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Average_Subarray_I
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 12, -5, -6, 50, 3 };
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_maxium_average_subarray(nums, 4));
            Console.ReadKey();
        }
    }
}
