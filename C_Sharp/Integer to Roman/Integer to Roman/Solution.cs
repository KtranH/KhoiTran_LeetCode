using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Roman
{
    internal class Solution
    {
        public string solve_roman_integer(int num)
        {
            string result = "";
            int[] val = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] sym = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            for(int i = 0; i < val.Length; i++)
            {
                while(num >= val[i])
                {
                    result += sym[i];
                    num -= val[i];
                }
            }    
            return result;
        }
    }
}
