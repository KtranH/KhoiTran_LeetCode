using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ransom_Note
{
    internal class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] arr = new int[26];
            foreach (var item in magazine)
            {
                arr[item - 'a']++;
            }
            foreach (var item in ransomNote)
            {
                arr[item - 'a']--;
                if (arr[item - 'a'] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
