using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: s = "III"
//Output: 3
//Explanation: III = 3.
//Example 2:

//Input: s = "LVIII"
//Output: 58
//Explanation: L = 50, V = 5, III = 3.
//Example 3:

//Input: s = "MCMXCIV"
//Output: 1994
//Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

namespace Roman_to_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string romanNumeral = "MCMXCIV"; // Example input
            int result = solution.solve_roman_to_integer(romanNumeral);
            Console.WriteLine($"The integer value of the Roman numeral {romanNumeral} is: {result}");
            Console.ReadKey();
        }
    }
}
