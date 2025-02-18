

//Example 1:


//Input: grid = [[3, 2, 1], [1, 7, 6], [2, 7, 7]]
//Output: 1
//Explanation: There is 1 equal row and column pair:
//-(Row 2, Column 1): [2,7,7]
//Example 2:


//Input: grid = [[3, 1, 2, 2], [1, 4, 4, 5], [2, 4, 2, 2], [2, 4, 2, 2]]
//Output: 3
//Explanation: There are 3 equal row and column pairs:
//-(Row 0, Column 0): [3, 1, 2, 2]
//- (Row 2, Column 2): [2, 4, 2, 2]
//- (Row 3, Column 2): [2,4,2,2]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Row_and_Column_Pairs
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[][] { new int[] { 13, 13 }, new int[] { 13, 13 }};
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_equal_row_and_column_pairs(grid));
            Console.ReadKey();
        }
    }
}
