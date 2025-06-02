using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_to_Integer
{
    internal class Solution
    {
        public int solve_roman_to_integer(string s)
        {
            Dictionary<char, int> romanToInt = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            int sum = 0;
            int n = s.Length;
            int i = 0;
            while (i < n)
            {
                if(i + 1 < n && romanToInt[s[i]] < romanToInt[s[i + 1]])
                {
                    sum += romanToInt[s[i + 1]] - romanToInt[s[i]];
                    i = i + 2;
                }
                else
                {
                    sum += romanToInt[s[i]];
                    i = i + 1;
                }    
            }    
            return sum;
        }
    }
}
