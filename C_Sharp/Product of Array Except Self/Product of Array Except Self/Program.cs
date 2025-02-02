//Example 1:

//Input: nums = [1, 2, 3, 4]
//Output: [24,12,8,6]
//Example 2:

//Input: nums = [-1, 1, 0, -3, 3]
//Output: [0,0,9,0,0]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_of_Array_Except_Self
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4 };
            Solution solution = new Solution();
            int[] result = solution.slove_product_of_array_except_self(ints);
            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
