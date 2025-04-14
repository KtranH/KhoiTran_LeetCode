using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: text1 = "abcde", text2 = "ace"
//Output: 3
//Explanation: The longest common subsequence is "ace" and its length is 3.
//Example 2:

//Input: text1 = "abc", text2 = "abc"
//Output: 3
//Explanation: The longest common subsequence is "abc" and its length is 3.
//Example 3:

//Input: text1 = "abc", text2 = "def"
//Output: 0
//Explanation: There is no such common subsequence, so the result is 0.

namespace Longest_Common_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = "abcde";
            string text2 = "ace";
            Solution solution = new Solution();
            int result = solution.solve_longest_common_subsequence(text1, text2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
