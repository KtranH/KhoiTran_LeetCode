using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: s = "Hello World"
//Output: 5
//Explanation: The last word is "World" with length 5.
//Example 2:

//Input: s = "   fly me   to   the moon  "
//Output: 4
//Explanation: The last word is "moon" with length 4.
//Example 3:

//Input: s = "luffy is still joyboy"
//Output: 6
//Explanation: The last word is "joyboy" with length 6.

namespace Length_of_Last_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string input = "   fly me   to   the moon  ";
            int length = solution.solve_length_of_last_word(input);
            Console.WriteLine($"Length of the last word in '{input}' is: {length}");
            Console.ReadKey();
        }
    }
}
