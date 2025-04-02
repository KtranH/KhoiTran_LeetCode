using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koko_Eating_Bananas
{
    internal class Solution
    {
        public int solve_koko_eating_piles(int[] piles, int h) {
            int left = 1;
            int right = piles.Max();
            while (left < right)
            {
                int mid = (left + right) / 2;
                int hours = 0;
                for (int i = 0; i < piles.Length; i++)
                {
                    hours += (piles[i] + mid - 1) / mid;
                }
                if (hours > h)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }
    }
}
