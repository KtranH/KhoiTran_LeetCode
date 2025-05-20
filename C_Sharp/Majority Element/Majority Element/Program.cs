using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: nums = [3, 2, 3]
//Output: 3
//Example 2:

//Input: nums = [2, 2, 1, 1, 1, 2, 2]
//Output: 2

namespace Majority_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            Solution solution = new Solution();
            int result = solution.solve_majority_element(nums);
            Console.WriteLine(result); // Output: 2
            Console.ReadLine();
        }
    }
}
