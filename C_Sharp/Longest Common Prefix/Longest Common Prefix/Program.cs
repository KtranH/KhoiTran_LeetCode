using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: strs = ["flower", "flow", "flight"]
//Output: "fl"
//Example 2:

//Input: strs = ["dog", "racecar", "car"]
//Output: ""
//Explanation: There is no common prefix among the input strings.

namespace Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };
            Solution solution = new Solution();
            string result = solution.solve_longest_common_prefix(strs);
            Console.WriteLine("Longest Common Prefix: " + result);
            Console.ReadLine();
        }
    }
}
