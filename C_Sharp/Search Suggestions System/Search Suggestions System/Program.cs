using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: products = ["mobile", "mouse", "moneypot", "monitor", "mousepad"], searchWord = "mouse"
//Output: [["mobile","moneypot","monitor"],["mobile","moneypot","monitor"],["mouse","mousepad"],["mouse","mousepad"],["mouse","mousepad"]]
//Explanation: products sorted lexicographically = ["mobile", "moneypot", "monitor", "mouse", "mousepad"].
//After typing m and mo all products match and we show user ["mobile", "moneypot", "monitor"].
//After typing mou, mous and mouse the system suggests ["mouse", "mousepad"].
//Example 2:

//Input: products = ["havana"], searchWord = "havana"
//Output: [["havana"],["havana"],["havana"],["havana"],["havana"],["havana"]]
//Explanation: The only word "havana" will be always suggested while typing the search word.

namespace Search_Suggestions_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = { "mobile", "mouse", "moneypot", "monitor", "mousepad" };
            string searchWord = "mouse";
            Solution solution = new Solution();
            IList<IList<string>> result = solution.solve_search_suggestions_system(products, searchWord);
            foreach (var list in result)
            {
                Console.WriteLine(string.Join(", ", list));
            }
            Console.ReadKey();
        }
    }
}
