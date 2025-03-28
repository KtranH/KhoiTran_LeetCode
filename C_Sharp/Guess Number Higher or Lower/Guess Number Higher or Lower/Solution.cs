using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Number_Higher_or_Lower
{
    internal class Solution
    {
        int guess(int num) { return 0; }
        public int solve_guess_number(int n)
        {
            int left = 1;
            int right = n;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int result = guess(mid);
                if (result == 0)
                {
                    return mid;
                }
                else if (result == -1)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
