using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: haystack = "sadbutsad", needle = "sad"
//Output: 0
//Explanation: "sad" occurs at index 0 and 6.
//The first occurrence is at index 0, so we return 0.
//Example 2:

//Input: haystack = "leetcode", needle = "leeto"
//Output: -1
//Explanation: "leeto" did not occur in "leetcode", so we return -1.

namespace Find_the_Index_of_the_First_Occurrence_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string haystack = "hello";
            string needle = "ll";
            int result = solution.StrStr(haystack, needle);
            Console.WriteLine(result); // Output: 2
            Console.ReadLine();
        }
    }
}
