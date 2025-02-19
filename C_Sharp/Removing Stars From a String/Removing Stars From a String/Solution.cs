using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Removing_Stars_From_a_String
{
    public class Solution
    {
        public string solve_removing_stars_from_a_string(string s)
        {
            List<char> stack = new List<char>();
            foreach(char c in s)
            {
                if (c == '*')
                {
                    if (stack.Count > 0) stack.RemoveAt(stack.Count - 1);
                }
                else
                {
                    stack.Add(c);
                }
            }
            return string.Join("", stack);
        }
    }
}
