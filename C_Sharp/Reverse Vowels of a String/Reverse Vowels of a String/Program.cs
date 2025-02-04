//Example 1:

//Input: s = "IceCreAm"

//Output: "AceCreIm"

//Explanation:

//The vowels in s are['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

//Example 2:

//Input: s = "leetcode"

//Output: "leotcede

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Vowels_of_a_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            string s = "leetcode";
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_reverse_vowels(s, vowels));
            Console.ReadKey();
        }
    }
}
