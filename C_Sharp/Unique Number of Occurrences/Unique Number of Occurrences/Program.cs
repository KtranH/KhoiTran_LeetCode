//Example 1:

//Input: arr = [1, 2, 2, 1, 1, 3]
//Output: true
//Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.
//Example 2:

//Input: arr = [1, 2]
//Output: false
//Example 3:

//Input: arr = [-3, 0, 1, -3, 1, 1, 1, -3, 10, 0]
//Output: true

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_Number_of_Occurrences
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2 };
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_unique_number_of_occurrences(nums));
            Console.ReadKey();
        }
    }
}
