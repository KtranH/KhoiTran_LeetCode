using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Vowels_of_a_String
{
    public class Solution
    {
        public string slove_reverse_vowels(string s, string[] vowels)
        {
            int count = s.Length;
            StringBuilder sb = new StringBuilder(s);
            for(int i = 0; i < sb.Length; i++)
            {
                if(vowels.Contains(sb[i].ToString()))
                {
                    for(int j = (sb.Length - 1) - (sb.Length - count); j > i; j--)
                    {
                        if(vowels.Contains(sb[j].ToString()))
                        {
                            char temp = sb[i];
                            sb[i] = sb[j];
                            sb[j] = temp;
                            count = j;
                            break;
                        }
                    }    
                }    
            }
            s = sb.ToString();
            return s;
        }
    }
}
