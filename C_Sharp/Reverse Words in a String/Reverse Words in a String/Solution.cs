using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reverse_Words_in_a_String
{
    public class Solution
    {
        public string solve_reverse_string(string s)
        {
            //string result = string.Join(" ", s.Split(' ').Reverse()).Trim();
            //return Regex.Replace(result, @"\s+", " ");
            string result = s.Trim();
            for (int i = 0; i < result.Length; i++)
            {
                if(result[i] == ' ' && result[i + 1] == ' ')
                {
                    result = result.Remove(i, 1);
                    i --;
                }    
            }    
            return string.Join(" ", result.Split(' ').Reverse());
        }
    }
}
