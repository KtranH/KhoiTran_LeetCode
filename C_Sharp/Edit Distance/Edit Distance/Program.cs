using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: word1 = "horse", word2 = "ros"
//Output: 3
//Explanation:
//horse->rorse(replace 'h' with 'r')
//rorse->rose(remove 'r')
//rose->ros(remove 'e')
//Example 2:

//Input: word1 = "intention", word2 = "execution"
//Output: 5
//Explanation:
//intention->inention(remove 't')
//inention->enention(replace 'i' with 'e')
//enention->exention(replace 'n' with 'x')
//exention->exection(replace 'n' with 'c')
//exection->execution(insert 'u')

namespace Edit_Distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_edit_distance("abc", "abc"));
            Console.ReadKey();
        }
    }
}
