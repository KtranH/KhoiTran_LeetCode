using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:



//Input: a = 2, b = 6, c = 5
//Output: 3
//Explanation: After flips a = 1 , b = 4 , c = 5 such that(a OR b == c)
//Example 2:

//Input: a = 4, b = 2, c = 7
//Output: 1
//Example 3:

//Input: a = 1, b = 2, c = 3
//Output: 0

namespace Minimum_Flips_to_Make_a_OR_b_Equal_to_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int a = 2;
            int b = 6;
            int c = 5;
            int result = solution.solve_min_flips_to_make_a_or_b_equal_to_c(a, b, c);
            Console.WriteLine(result); 
            Console.ReadLine();
        }
    }
}
