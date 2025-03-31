using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Successful_Pairs_of_Spells_and_Potions
{
    internal class Solution
    {
        public int[] solve_successful_pairs(int[] spells, int[] potions, long success) {
            Array.Sort(potions);
            int m = potions.Length;
            int[] results = new int[spells.Length];

            for (int i = 0; i < spells.Length; i++)
            {
                long min_potion = (success + spells[i] - 1) / spells[i];

                int left = 0, right = m - 1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (potions[mid] >= min_potion)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                results[i] = m - left;
            }
            return results;
        }
    }
}
