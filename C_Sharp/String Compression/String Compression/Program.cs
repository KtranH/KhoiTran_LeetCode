//Example 1:

//Input: chars = ["a", "a", "b", "b", "c", "c", "c"]
//Output: Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]
//Explanation: The groups are "aa", "bb", and "ccc". This compresses to "a2b2c3".
//Example 2:

//Input: chars = ["a"]
//Output: Return 1, and the first character of the input array should be: ["a"]
//Explanation: The only group is "a", which remains uncompressed since it's a single character.
//Example 3:

//Input: chars = ["a", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b"]
//Output: Return 4, and the first 4 characters of the input array should be: ["a", "b", "1", "2"].
//Explanation: The groups are "a" and "bbbbbbbbbbbb". This compresses to "ab12".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Compression
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_string_compression(chars));
            Console.ReadKey();
        }
    }
}
