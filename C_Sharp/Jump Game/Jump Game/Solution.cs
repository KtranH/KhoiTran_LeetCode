using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Game
{
    internal class Solution
    {
        public bool solve_jump_game(int[] nums) {
            int n = nums.Length;
            int max_research = 0;
            for (int i = 0; i < n; i++)
            {
                if(i > max_research)
                {
                    return false;
                }
                int tempt = i + nums[i];
                if (tempt > max_research)
                {
                    max_research = tempt;
                }
            }
            return true;
        }
    }
}
