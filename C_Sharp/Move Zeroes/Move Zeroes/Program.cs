//Example 1:

//Input: nums = [0, 1, 0, 3, 12]
//Output: [1,3,12,0,0]
//Example 2:

//Input: nums = [0]
//Output: [0]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Zeroes
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 0, 1, 2, 0, 3, 12 };
            Solution solution = new Solution();
            solution.solve_move_zeroes(nums);
            Console.ReadKey();
        }
    }
}
