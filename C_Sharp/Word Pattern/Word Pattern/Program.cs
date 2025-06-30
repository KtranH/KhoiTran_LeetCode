using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: pattern = "abba", s = "dog cat cat dog"

//Output: true

//Explanation:

//The bijection can be established as:

//'a' maps to "dog".
//'b' maps to "cat".
//Example 2:

//Input: pattern = "abba", s = "dog cat cat fish"

//Output: false

//Example 3:

//Input: pattern = "aaaa", s = "dog cat cat dog"

//Output: false

namespace Word_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_word_pattern("abba", "dog cat cat dog")); // True
            Console.WriteLine(solution.solve_word_pattern("abba", "dog cat cat fish")); // False
            Console.WriteLine(solution.solve_word_pattern("aaaa", "dog dog dog dog")); // True
            Console.WriteLine(solution.solve_word_pattern("abba", "dog dog dog dog")); // False
            Console.ReadLine();
        }
    }
}
