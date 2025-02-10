using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length
{
    public class Solution
    {
        public int solve_maximum_number_of_vowels_in_a_substring_of_given_length(string s, int k)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            int sliding_window = 0;
            for (int i = 0; i < k; i++)
            {
                if(vowels.Contains(s[i]))
                {
                    sliding_window++;
                }    
            }
            int max_vowels = sliding_window;
            for (int i = k; i < s.Length; i++)
            {
                if(vowels.Contains(s[i - k]))
                {
                    sliding_window--;
                }    
                if(vowels.Contains(s[i]))
                {
                    sliding_window++;
                }    
                if(sliding_window > max_vowels)
                {
                    max_vowels = sliding_window;
                }    
            }    
            return max_vowels;
        }
    }
}
