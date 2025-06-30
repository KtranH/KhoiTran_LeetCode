using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Pattern
{
    internal class Solution
    {
        public bool solve_word_pattern(string pattern, string s)
        {
            string[]words = s.Split(' ');
            if (pattern.Length != words.Length)
            {
                return false;
            }
            Dictionary<char, string> charToWord = new Dictionary<char, string>();
            for(int i = 0; i < pattern.Length; i++)
            {
                if(!charToWord.ContainsKey(pattern[i]))
                {
                    if (charToWord.ContainsValue(words[i]))
                    {
                        return false;
                    }
                    charToWord[pattern[i]] = words[i];
                }
                else
                {
                    if (charToWord[pattern[i]] != words[i])
                    {
                        return false;
                    }
                }    
            }
            return true;
        }
    }
}
