using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Index_of_the_First_Occurrence_in_a_String
{
    internal class Solution
    {
        public int StrStr(string haystack, string needle)
        {
           if(haystack.Contains(needle))
            {
                return haystack.IndexOf(needle);
            }
            return -1;
        }
    }
}
