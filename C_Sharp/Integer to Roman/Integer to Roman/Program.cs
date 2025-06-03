using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: num = 3749

//Output: "MMMDCCXLIX"

//Explanation:

//3000 = MMM as 1000(M) + 1000(M) + 1000(M)
// 700 = DCC as 500(D) + 100(C) + 100(C)
//  40 = XL as 10(X) less of 50 (L)
//   9 = IX as 1 (I) less of 10 (X)
//Note: 49 is not 1(I) less of 50 (L) because the conversion is based on decimal places
//Example 2:

//Input: num = 58

//Output: "LVIII"

//Explanation:

//50 = L
// 8 = VIII
//Example 3:

//Input: num = 1994

//Output: "MCMXCIV"

//Explanation:

//1000 = M
// 900 = CM
//  90 = XC
//   4 = IV

namespace Integer_to_Roman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_roman_integer(1994));
            Console.ReadKey();
        }
    }
}
