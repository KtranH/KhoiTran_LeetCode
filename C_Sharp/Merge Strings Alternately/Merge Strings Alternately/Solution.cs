using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Strings_Alternately
{
    public class Solution
    {
        public void string_remain(ref String result, int flag, int word_max, String word1, String word2)
        {
            if (word_max == 1)
            {
                for (int i = flag; i < word1.Length; i++)
                {
                    result += word1[i];
                }
            }
            else
            {
                for (int i = flag; i < word2.Length; i++)
                {
                    result += word2[i];
                }
            }
        }
        public void check_flag(ref int flag, ref int word_max, int max_length, String word1, String word2)
        {
            if (max_length != word1.Length)
            {
                flag = word1.Length;
                word_max = 2;
            }
            else
            {
                flag = word2.Length;
                word_max = 1;
            }
        }
        public String solve_merge_strings_alternately(String word1, String word2)
        {
            String result = "";
            int max_length = Math.Max(word1.Length, word2.Length);
            int flag = max_length;
            int word_max = 1;
            this.check_flag(ref flag, ref word_max, max_length, word1, word2);
            for (int i = 0; i < flag; i++)
            {
                result += word1[i];
                result += word2[i];
            }    
            this.string_remain(ref result, flag, word_max, word1, word2);
            return result;
        }
    }
}
