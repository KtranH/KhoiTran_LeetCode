//Example 1:


//Input: root = [4, 2, 7, 1, 3], val = 2
//Output: [2,1,3]
//Example 2:


//Input: root = [4, 2, 7, 1, 3], val = 5
//Output: []

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_in_a_Binary_Search_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] values = { 1, 2, 3, 4, 5 };
            foreach (int value in values)
            {
                solution.insert(value);
            }    
            Console.WriteLine(solution.solve_search_in_a_search_tree(2).val);
            Console.ReadKey();
        }
    }
}
