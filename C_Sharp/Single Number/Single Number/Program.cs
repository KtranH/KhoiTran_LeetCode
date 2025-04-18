using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: nums = [2, 2, 1]

//Output: 1

//Example 2:

//Input: nums = [4, 1, 2, 1, 2]

//Output: 4

//Example 3:

//Input: nums = [1]

//Output: 1

namespace Single_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 4, 1, 2, 1, 2 };
            Console.WriteLine(solution.solve_single_number(nums));
            Console.ReadLine();
        }
    }
}
