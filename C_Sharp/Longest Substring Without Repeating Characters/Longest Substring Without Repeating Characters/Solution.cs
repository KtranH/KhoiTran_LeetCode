using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Solution
    {
        public int solve_longest_substring_without_repeating_characters(string s)
        {
            int n = s.Length;
            int maxLength = 0;
            int left = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int right = 0; right < n; right++)
            {
                if (map.ContainsKey(s[right]) && map[s[right]] >= left)
                {
                    left = map[s[right]] + 1;
                }
                map[s[right]] = right;
                int currentLength = right - left + 1;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            return maxLength;
        }
    }
}
