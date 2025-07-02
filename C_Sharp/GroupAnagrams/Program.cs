using System;
using System.Collections;
using System.Collections.Generic;

namespace GroupAnagrams
{
    class Program
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> strs_map = new Dictionary<string, IList<string>>();
            foreach (string s in strs)
            {
                char[] charArray = s.ToCharArray();
                Array.Sort(charArray);
                string sortedString = new string(charArray);
                if (strs_map.ContainsKey(sortedString))
                {
                    strs_map[sortedString].Add(s);
                }
                else
                {
                    strs_map[sortedString] = new List<string> { s };
                }
            }
            return strs_map.Values.ToList();
        }
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> result = solution.GroupAnagrams(strs);
            foreach (IList<string> group in result)
            {
                Console.WriteLine(string.Join(", ", group));
            }
            Console.ReadKey();
        }
    }
}
