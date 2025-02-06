//Example 1:

//Input: s = "abc", t = "ahbgdc"
//Output: true
//Example 2:

//Input: s = "axc", t = "ahbgdc"
//Output: false

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Subsequence
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "abc";
            string t = "ahbgdc";

            Solution solution = new Solution();
            Console.WriteLine(solution.solve_is_subsequence(s, t));
            Console.ReadKey();
        }
    }
}
