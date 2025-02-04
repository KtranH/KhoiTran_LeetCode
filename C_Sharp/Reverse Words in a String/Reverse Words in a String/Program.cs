//Example 1:

//Input: s = "the sky is blue"
//Output: "blue is sky the"
//Example 2:

//Input: s = "  hello world  "
//Output: "world hello"
//Explanation: Your reversed string should not contain leading or trailing spaces.
//Example 3:

//Input: s = "a good   example"
//Output: "example good a"
//Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Words_in_a_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_reverse_string("the sky is blue"));
            Console.ReadKey();
        }
    }
}
