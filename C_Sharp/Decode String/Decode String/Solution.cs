using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decode_String
{
    public class Solution
    {
        public string solve_decode_string(string s)
        {
            string current_string = "";
            int current_number = 0;
            Stack<(int, string)> stack = new Stack<(int, string)>();

            foreach (char c in s)
            {
                if (Char.IsDigit(c))
                {
                    current_number = current_number * 10 + (c - '0'); 
                }
                else if (c == '[')
                {
                    stack.Push((current_number, current_string));
                    current_number = 0;
                    current_string = "";
                }
                else if (c == ']')
                {
                    var (num, prev_string) = stack.Pop();
                    current_string = prev_string + string.Concat(Enumerable.Repeat(current_string, num)); 
                }
                else
                {
                    current_string += c;
                }
            }
            return current_string;
        }
    }
}
