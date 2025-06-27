using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isomorphic_Strings
{
    internal class Solution
    {
        public bool solve_isomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            Dictionary<char, char> map_s_t = new Dictionary<char, char>();
            Dictionary<char, char> map_t_s = new Dictionary<char, char>();
            for(int i = 0; i < s.Length; i++)
            {
                if (map_s_t.ContainsKey(s[i]))
                {
                    if (map_s_t[s[i]] != t[i]) return false;
                }
                else
                {
                    map_s_t[s[i]] = t[i];
                }
                if(map_t_s.ContainsKey(t[i]))
                {
                    if (map_t_s[t[i]] != s[i]) return false;
                }
                else
                {
                    map_t_s[t[i]] = s[i];
                }
            }
            return true;
        }
    }
}
