//Example 1:


//Input: n = 3
//Output: 5
//Explanation: The five different ways are show above.
//Example 2:

//Input: n = 1
//Output: 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino_and_Tromino_Tiling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Solution solution = new Solution();
            int result = solution.solve_domino_and_tromino_tiling(n);
            Console.WriteLine(result); 
            Console.ReadLine();
        }
    }
}
