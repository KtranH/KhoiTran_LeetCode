//Example 1:

//Input: nums1 = [1, 2, 3], nums2 = [2, 4, 6]
//Output: [[1,3],[4,6]]
//Explanation:
//For nums1, nums1[1] = 2 is present at index 0 of nums2, whereas nums1[0] = 1 and nums1[2] = 3 are not present in nums2. Therefore, answer[0] = [1, 3].
//For nums2, nums2[0] = 2 is present at index 1 of nums1, whereas nums2[1] = 4 and nums2[2] = 6 are not present in nums2. Therefore, answer[1] = [4, 6].
//Example 2:

//Input: nums1 = [1, 2, 3, 3], nums2 = [1, 1, 2, 2]
//Output: [[3],[]]
//Explanation:
//For nums1, nums1[2] and nums1[3] are not present in nums2. Since nums1[2] == nums1[3], their value is only included once and answer[0] = [3].
//Every integer in nums2 is present in nums1. Therefore, answer[1] = [].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Difference_of_Two_Arrays
{
    public class Program
    {
        static void print_list(IList<IList<int>> result)
        {
            foreach (IList<int> list in result)
            {
                foreach (int num in list)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3 };
            int[] nums2 = new int[] { 2, 4, 6 };
            Solution s = new Solution();
            IList<IList<int>> result = s.solve_find_the_difference_of_two_arrays(nums1, nums2);
            print_list(result);
            Console.ReadKey();
        }
    }
}
