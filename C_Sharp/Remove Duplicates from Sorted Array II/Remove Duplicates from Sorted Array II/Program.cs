using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: nums = [1, 1, 1, 2, 2, 3]
//Output: 5, nums = [1, 1, 2, 2, 3, _]
//Explanation: Your function should return k = 5, with the first five elements of nums being 1, 1, 2, 2 and 3 respectively.
//It does not matter what you leave beyond the returned k (hence they are underscores).
//Example 2:

//Input: nums = [0, 0, 1, 1, 1, 1, 2, 3, 3]
//Output: 7, nums = [0, 0, 1, 1, 2, 3, 3, _, _]
//Explanation: Your function should return k = 7, with the first seven elements of nums being 0, 0, 1, 1, 2, 3 and 3 respectively.
//It does not matter what you leave beyond the returned k (hence they are underscores).

namespace Remove_Duplicates_from_Sorted_Array_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            Solution solution = new Solution();
            int result = solution.solve_remove_duplicates(nums);
            Console.WriteLine("The length of the modified array is: " + result);
            Console.WriteLine("The modified array is: " + string.Join(", ", nums.Take(result)));
            Console.ReadKey();
        }
    }
}
