//Example 1:

//Input: n = 4
//Output: 4
//Explanation:
//T_3 = 0 + 1 + 1 = 2
//T_4 = 1 + 1 + 2 = 4
//Example 2:

//Input: n = 25
//Output: 1389537

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace N_th_Tribonacci_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_n_th_tribonacci_number(4)); 
            Console.WriteLine(solution.solve_n_th_tribonacci_number(25));
        }
    }
}
