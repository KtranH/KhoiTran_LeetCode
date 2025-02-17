//Example 1:

//Input: word1 = "abc", word2 = "bca"
//Output: true
//Explanation: You can attain word2 from word1 in 2 operations.
//Apply Operation 1: "abc"-> "acb"
//Apply Operation 1: "acb"-> "bca"
//Example 2:

//Input: word1 = "a", word2 = "aa"
//Output: false
//Explanation: It is impossible to attain word2 from word1, or vice versa, in any number of operations.
//Example 3:

//Input: word1 = "cabbba", word2 = "abbccc"
//Output: true
//Explanation: You can attain word2 from word1 in 3 operations.
//Apply Operation 1: "cabbba"-> "caabbb"
//Apply Operation 2: "caabbb"-> "baaccc"
//Apply Operation 2: "baaccc"-> "abbccc"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determine_if_Two_Strings_Are_Close
{
    public class Program
    {
        static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "bca";
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_determine_if_two_string_are_close(word1, word2));
            Console.ReadKey();
        }
    }
}
