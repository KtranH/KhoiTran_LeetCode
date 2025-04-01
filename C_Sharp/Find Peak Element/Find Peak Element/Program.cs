//Example 1:

//Input: nums = [1, 2, 3, 1]
//Output: 2
//Explanation: 3 is a peak element and your function should return the index number 2.
//Example 2:

//Input: nums = [1, 2, 1, 3, 5, 6, 4]
//Output: 5
//Explanation: Your function can return either index number 1 where the peak element is 2, or index number 5 where the peak element is 6.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Peak_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1 };
            Solution sol = new Solution();
            Console.WriteLine(sol.solve_find_peak_element(nums));
            Console.ReadLine();
        }
    }
}
