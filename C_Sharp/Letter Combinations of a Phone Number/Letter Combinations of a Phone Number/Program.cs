//Example 1:

//Input: digits = "23"
//Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
//Example 2:

//Input: digits = ""
//Output: []
//Example 3:

//Input: digits = "2"
//Output: ["a","b","c"]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Combinations_of_a_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            IList<string> result = solution.solve_letter_combinations("23");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }    
            Console.ReadKey();
        }
    }
}
