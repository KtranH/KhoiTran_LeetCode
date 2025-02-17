using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determine_if_Two_Strings_Are_Close
{
    public class Solution
    {
        public bool solve_determine_if_two_string_are_close(string word1, string word2)
        {
            if (word1.Length != word2.Length) return false;

            Dictionary<char, int> hashmap1 = new Dictionary<char, int>();
            Dictionary<char, int> hashmap2 = new Dictionary<char, int>();

            for (int i = 0; i < word1.Length; i++)
            {
                if (!hashmap1.ContainsKey(word1[i]))
                    hashmap1.Add(word1[i], 1);
                else
                    hashmap1[word1[i]]++;

                if (!hashmap2.ContainsKey(word2[i]))
                    hashmap2.Add(word2[i], 1);
                else
                    hashmap2[word2[i]]++;
            }

            if (!new HashSet<char>(hashmap1.Keys).SetEquals(hashmap2.Keys))
                return false;

            return hashmap1.Values.OrderBy(x => x).SequenceEqual(hashmap2.Values.OrderBy(x => x));
        }
    }
}
