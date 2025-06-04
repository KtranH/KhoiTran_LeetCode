using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_Last_Word
{
    internal class Solution
    {
        public int solve_length_of_last_word(string s)
        {
            s = s.Trim();
            string[] words = s.Split(' ');
            int length = words[words.Length - 1].Length; 
            return length;
        }
    }
}
