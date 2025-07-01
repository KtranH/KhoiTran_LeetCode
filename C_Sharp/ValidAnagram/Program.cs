// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

/*Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false*/

namespace ValidAnagram
{
    class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> s_map = new Dictionary<char, int>();
            Dictionary<char, int> t_map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s_map.ContainsKey(s[i]))
                {
                    s_map[s[i]]++;
                }
                else
                {
                    s_map[s[i]] = 1;
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (t_map.ContainsKey(t[i]))
                {
                    t_map[t[i]]++;
                }
                else
                {
                    t_map[t[i]] = 1;
                }
            }
            if (s_map.Count != t_map.Count)
            {
                return false;
            }
            foreach (var item in s_map)
            {
                if (!t_map.ContainsKey(item.Key) || t_map[item.Key] != item.Value)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsAnagram("anagram", "nagaram"));
            Console.ReadKey();
        }
    }
}
