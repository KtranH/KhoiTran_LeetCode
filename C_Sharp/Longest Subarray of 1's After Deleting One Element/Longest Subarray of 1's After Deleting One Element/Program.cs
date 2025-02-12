
//Example 1:

//Input: nums = [1, 1, 0, 1]
//Output: 3
//Explanation: After deleting the number in position 2, [1, 1, 1] contains 3 numbers with value of 1's.
//Example 2:

//Input: nums = [0, 1, 1, 1, 0, 1, 1, 0, 1]
//Output: 5
//Explanation: After deleting the number in position 4, [0, 1, 1, 1, 1, 1, 0, 1] longest subarray with value of 1's is [1,1,1,1,1].
//Example 3:

//Input: nums = [1, 1, 1]
//Output: 2
//Explanation: You must delete one element.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Subarray_of_1_s_After_Deleting_One_Element
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 0, 1 };
            Solution solution = new Solution();
            Console.WriteLine(solution.soved_solve_longest_subarray_of_1s_after_deleting_one_element(nums));
            Console.ReadKey();
        }
    }
}
