//Example 1:


//Input: root = [1, null, 1, 1, 1, null, null, 1, 1, null, 1, null, null, null, 1]
//Output: 3
//Explanation: Longest ZigZag path in blue nodes (right -> left -> right).
//Example 2:


//Input: root = [1, 1, 1, null, 1, null, null, 1, 1, null, 1]
//Output: 4
//Explanation: Longest ZigZag path in blue nodes (left -> right -> left -> right).
//Example 3:

//Input: root = [1]
//Output: 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_ZigZag_Path_in_a_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Node root = solution.insert_level_order(new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1 });
            Console.WriteLine(solution.solve_longest_zigzag_path_in_a_binary_tree(root));
            Console.ReadKey();
        }
    }
}
