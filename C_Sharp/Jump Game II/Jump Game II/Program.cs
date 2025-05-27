using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: nums = [2, 3, 1, 1, 4]
//Output: 2
//Explanation: The minimum number of jumps to reach the last index is 2. Jump 1 step from index 0 to 1, then 3 steps to the last index.
//Example 2:

//Input: nums = [2, 3, 0, 1, 4]
//Output: 2

namespace Jump_Game_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 1, 1, 4 };
            Solution solution = new Solution();
            int result = solution.solve_jump_game_ii(nums);
            Console.WriteLine("Minimum number of jumps to reach the end: " + result);
            Console.ReadLine();
        }
    }
}
