//Example 1:

//Input: s = "3[a]2[bc]"
//Output: "aaabcbc"
//Example 2:

//Input: s = "3[a2[c]]"
//Output: "accaccacc"
//Example 3:

//Input: s = "2[abc]3[cd]ef"
//Output: "abcabccdcdcdef"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decode_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "3[a]2[bc]";
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_decode_string(s));
            Console.ReadKey();
        }
    }
}
