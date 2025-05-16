using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: nums = [1, 1, 2]
//Output: 2, nums = [1, 2, _]
//Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
//It does not matter what you leave beyond the returned k (hence they are underscores).
//Example 2:

//Input: nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
//Output: 5, nums = [0, 1, 2, 3, 4, _, _, _, _, _]
//Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
//It does not matter what you leave beyond the returned k (hence they are underscores).

namespace Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2 };
            Solution solution = new Solution();
            int result = solution.solve_remove_duplicates(nums);
            Console.WriteLine(result); // Output: 2
            Console.WriteLine(string.Join(", ", nums.Take(result))); // Output: 1, 2
            Console.ReadKey();
        }
    }
}
