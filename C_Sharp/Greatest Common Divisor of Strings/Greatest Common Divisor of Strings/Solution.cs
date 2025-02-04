//Example 1:

//Input: str1 = "ABCABC", str2 = "ABC"
//Output: "ABC"
//Example 2:

//Input: str1 = "ABABAB", str2 = "ABAB"
//Output: "AB"
//Example 3:

//Input: str1 = "LEET", str2 = "CODE"
//Output: ""

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor_of_Strings
{
    public class Solution
    {
        public string word1 = "ABCABC";
        public string word2 = "ABC";
        public int Find_GCD(int a, int b)
        {
            int min = Math.Min(a, b);
            int GCD = 0;
            for (int i = 1; i <= min; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    GCD = i;
                }
            }
            return GCD;
        }
        public bool check_string(string s1, string s2)
        {
            if(s1 + s2 != s2 + s1)
            {
                return false;
            }
            return true;
        }
        public string solve_Greatest_Common_Divisor_Of_Strings()
        {
            if (!check_string(word1, word2))
            {
                return "";
            }
            int GCD = Find_GCD(word1.Length, word2.Length);
            if(word1.Length > word2.Length)
            {
                return word1.Substring(0, GCD);
            }
            else
            {
                return word2.Substring(0, GCD);
            }    
        }
    }
}
