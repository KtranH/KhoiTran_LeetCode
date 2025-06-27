using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: s = "egg", t = "add"

//Output: true

//Explanation:

//The strings s and t can be made identical by:

//Mapping 'e' to 'a'.
//Mapping 'g' to 'd'.
//Example 2:

//Input: s = "foo", t = "bar"

//Output: false

//Explanation:

//The strings s and t can not be made identical as 'o' needs to be mapped to both 'a' and 'r'.

//Example 3:

//Input: s = "paper", t = "title"

//Output: true



namespace Isomorphic_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_isomorphic("egg", "add"));
            Console.ReadKey();
        }
    }
}
