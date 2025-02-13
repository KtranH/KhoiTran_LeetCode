//Example 1:

//Input: gain = [-5, 1, 5, 0, -7]
//Output: 1
//Explanation: The altitudes are[0, -5, -4, 1, 1, -6].The highest is 1.
//Example 2:

//Input: gain = [-4, -3, -2, -1, 4, 3, 2]
//Output: 0
//Explanation: The altitudes are[0, -4, -7, -9, -10, -6, -3, -1].The highest is 0.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Highest_Altitude
{
    public class Solution
    {
        public int solve_find_the_highest_altitude(int[] gain)
        {
            List<int> gain_temp = new List<int>();
            gain_temp = gain.ToList();

            gain_temp.Insert(0, 0);

            int max_altitude = 0;
            int current_altitude = 0;
            int prelix_sum = 0;

            for(int i = 0; i < gain_temp.Count; i++)
            {
                prelix_sum += gain_temp[i];
                current_altitude = prelix_sum;
                if (current_altitude > max_altitude) max_altitude = current_altitude;
            }    
            return max_altitude;
        }
    }
}
