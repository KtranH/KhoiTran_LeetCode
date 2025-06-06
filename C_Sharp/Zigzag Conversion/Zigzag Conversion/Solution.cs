using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zigzag_Conversion
{
    internal class Solution
    {
        public string solve_zigzag_conversion(string s, int rows)
        {
            if (rows == 1)
            {
                return s;
            }
            string result = "";
            int n = s.Length;
            int step = 2 * (rows - 1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < n; j += step)
                {
                    result += s[j];
                    if (i > 0 && i < rows - 1 && j + step - 2 * i < n)
                    {
                        result += s[j + step - 2 * i];
                    }
                }
            }
            return result;
        }
    }
}
