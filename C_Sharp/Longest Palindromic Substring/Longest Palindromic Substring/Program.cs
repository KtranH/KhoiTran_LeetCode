using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: s = "babad"
//Output: "bab"
//Explanation: "aba" is also a valid answer.
//Example 2:

//Input: s = "cbbd"
//Output: "bb"

namespace Longest_Palindromic_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "babad";
            Solution solution = new Solution();
            string result = solution.solve_longest_palindromic_substring(s);
            Console.WriteLine(result); // Output: "bab" or "aba"
            Console.ReadKey();
        }
    }
}
