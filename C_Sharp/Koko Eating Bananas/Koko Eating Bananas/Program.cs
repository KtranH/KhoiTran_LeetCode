//Example 1:

//Input: piles = [3, 6, 7, 11], h = 8
//Output: 4
//Example 2:

//Input: piles = [30, 11, 23, 4, 20], h = 5
//Output: 30
//Example 3:

//Input: piles = [30, 11, 23, 4, 20], h = 6
//Output: 23

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koko_Eating_Bananas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] piles = new int[] { 3, 6, 7, 11 };
            int h = 8;
            Console.WriteLine(solution.solve_koko_eating_piles(piles, h));
            Console.ReadKey();
        }
    }
}
