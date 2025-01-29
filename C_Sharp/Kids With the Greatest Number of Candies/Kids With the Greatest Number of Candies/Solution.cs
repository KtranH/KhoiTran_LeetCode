using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_With_the_Greatest_Number_of_Candies
{
    public class Solution
    {
        public bool[] sloved_kids_the_greatest_number_of_candies(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            bool[] result = new bool[candies.Length];
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                {
                    result[i] = true;
                }
                else
                {
                    result[i] = false;
                }    
            }
            return result;
        }
    }
}
