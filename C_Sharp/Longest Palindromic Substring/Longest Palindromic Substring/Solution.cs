using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Palindromic_Substring
{
    internal class Solution
    {
        public string expand_from_center(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return s.Substring(left + 1, right - left - 1);
        }
        public string solve_longest_palindromic_substring(string s)
        {
            int n = s.Length;
            string res = "";
            for (int i = 0; i < n; i++)
            {
                string s1 = expand_from_center(s, i, i);
                string s2 = expand_from_center(s, i, i + 1);
                res = res.Length > s1.Length ? res : s1;
                res = res.Length > s2.Length ? res : s2;
            }
            return res;
        }
    }
}
