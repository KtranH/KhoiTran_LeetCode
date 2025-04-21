using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Flips_to_Make_a_OR_b_Equal_to_c
{
    internal class Solution
    {
        public int solve_min_flips_to_make_a_or_b_equal_to_c(int a, int b, int c)
        {
            int flip = 0;
            for(int i = 0; i < 32; i++)
            {
                int a_bit = (a >> i) & 1;
                int b_bit = (b >> i) & 1;
                int c_bit = (c >> i) & 1;

                int orResult = a_bit | b_bit;

                if(orResult == c_bit)
                {
                    continue;
                }
                if(c_bit == 1)
                {
                    flip += 1;
                }
                else
                {
                    flip += a_bit + b_bit;
                }
            }   
            return flip;
        }
    }
}
