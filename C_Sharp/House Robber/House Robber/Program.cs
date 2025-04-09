//Example 1:

//Input: nums = [1, 2, 3, 1]
//Output: 4
//Explanation: Rob house 1(money = 1) and then rob house 3 (money = 3).
//Total amount you can rob = 1 + 3 = 4.
//Example 2:

//Input: nums = [2, 7, 9, 3, 1]
//Output: 12
//Explanation: Rob house 1(money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
//Total amount you can rob = 2 + 9 + 1 = 12.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Robber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 9, 3, 1 };
            Solution solution = new Solution();
            int result = solution.solve_house_robber(nums);
            Console.WriteLine(result); 
            Console.ReadLine();
        }
    }
}
