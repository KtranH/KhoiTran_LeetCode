//Example 1:

//Input: nums = [3, 2, 1, 5, 6, 4], k = 2
//Output: 5
//Example 2:

//Input: nums = [3, 2, 3, 1, 2, 4, 5, 5, 6], k = 4
//Output: 4


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kth_Largest_Element_in_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_kth_largest_element_in_an_array(new int[] { 3, 2, 1, 5, 6, 4 }, 2));
            Console.ReadKey();
        }
    }
}
