//Example 1:

//Input: s = "abciiidef", k = 3
//Output: 3
//Explanation: The substring "iii" contains 3 vowel letters.
//Example 2:

//Input: s = "aeiou", k = 2
//Output: 2
//Explanation: Any substring of length 2 contains 2 vowels.
//Example 3:

//Input: s = "leetcode", k = 3
//Output: 2
//Explanation: "lee", "eet" and "ode" contain 2 vowels.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "abciiidef";
            int k = 3;
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_maximum_number_of_vowels_in_a_substring_of_given_length(s, k));
            Console.ReadKey();
        }
    }
}
