using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: s = "PAYPALISHIRING", numRows = 3
//Output: "PAHNAPLSIIGYIR"
//Example 2:

//Input: s = "PAYPALISHIRING", numRows = 4
//Output: "PINALSIGYAHRPI"
//Explanation:
//P I    N
//A   L S  I G
//Y A   H R
//P     I
//Example 3:

//Input: s = "A", numRows = 1
//Output: "A"

namespace Zigzag_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "PAYPALISHIRING";
            int rows = 3;
            Solution solution = new Solution();
            string result = solution.solve_zigzag_conversion(s, rows);
            Console.WriteLine(result); // Output: "PAHNAPLSIIGYIR"
            Console.WriteLine();
        }
    }
}
