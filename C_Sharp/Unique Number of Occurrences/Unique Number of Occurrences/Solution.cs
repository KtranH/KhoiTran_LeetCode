using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_Number_of_Occurrences
{
    public class Solution
    {
        public bool solve_unique_number_of_occurrences(int[] nums)
        {
            Dictionary<int,int> hashmap = new Dictionary<int,int>();
            foreach (int num in nums)
            {
                if (hashmap.ContainsKey(num))
                {
                    hashmap[num]++;
                }
                else
                {
                    hashmap[num] = 1;
                }
            }
            HashSet<int> hashset = new HashSet<int>();
            foreach(int value in hashmap.Values)
            {
                hashset.Add(value);
            }    
            if(hashset.Count != hashmap.Count) return false;
            return true;
        }
    }
}
