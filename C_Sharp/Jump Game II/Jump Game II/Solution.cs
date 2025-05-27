using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Game_II
{
    internal class Solution
    {
        public int solve_jump_game_ii(int[] nums)
        {
            int n = nums.Length;
            int currentEnd = 0;
            int farthest = 0;
            int jump = 0;
            for(int i = 0; i < n - 1; i++)
            {
                farthest = Math.Max(farthest, i + nums[i]);
                if (i == currentEnd)
                {
                    jump++;
                    currentEnd = farthest;
                }
            }    
            return jump;
        }
    }
}
