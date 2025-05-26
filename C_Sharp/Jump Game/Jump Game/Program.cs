using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: nums = [2, 3, 1, 1, 4]
//Output: true
//Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
//Example 2:

//Input: nums = [3, 2, 1, 0, 4]
//Output: false
//Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.

namespace Jump_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 2, 3, 1, 1, 4 };
            Console.WriteLine(solution.solve_jump_game(nums));
            Console.ReadKey();
        }
    }
}
