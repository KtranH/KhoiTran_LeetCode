using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:


//Input: matrix = [["1", "0", "1", "0", "0"], ["1", "0", "1", "1", "1"], ["1", "1", "1", "1", "1"], ["1", "0", "0", "1", "0"]]
//Output: 4
//Example 2:


//Input: matrix = [["0", "1"], ["1", "0"]]
//Output: 1
//Example 3:

//Input: matrix = [["0"]]
//Output: 0


namespace Maximal_Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] matrix = new char[][]
            {
                new char[] { '1', '0', '1', '0', '0' },
                new char[] { '1', '0', '1', '1', '1' },
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '0', '0', '1', '0' }
            };

            Solution solution = new Solution();
            int result = solution.solve_maximal_square(matrix);
            Console.WriteLine(result); // Output: 4
            Console.ReadLine();
        }
    }
}
