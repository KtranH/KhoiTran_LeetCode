using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: s = "leetcode", wordDict = ["leet", "code"]
//Output: true
//Explanation: Return true because "leetcode" can be segmented as "leet code".
//Example 2:

//Input: s = "applepenapple", wordDict = ["apple", "pen"]
//Output: true
//Explanation: Return true because "applepenapple" can be segmented as "apple pen apple".
//Note that you are allowed to reuse a dictionary word.
//Example 3:

//Input: s = "catsandog", wordDict = ["cats", "dog", "sand", "and", "cat"]
//Output: false

namespace Word_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "leetcode";
            IList<string> wordDict = new List<string> { "leet", "code" };
            Solution solution = new Solution();
            bool result = solution.solve_word_break(s, wordDict);
            Console.WriteLine(result); // Output: True
            Console.ReadKey();
        }
    }
}
