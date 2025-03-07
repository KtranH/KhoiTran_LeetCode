//Example 1:


//Input: root = [3, 5, 1, 6, 2, 0, 8, null, null, 7, 4], p = 5, q = 1
//Output: 3
//Explanation: The LCA of nodes 5 and 1 is 3.
//Example 2:


//Input: root = [3, 5, 1, 6, 2, 0, 8, null, null, 7, 4], p = 5, q = 4
//Output: 5
//Explanation: The LCA of nodes 5 and 4 is 5, since a node can be a descendant of itself according to the LCA definition.
//Example 3:

//Input: root = [1, 2], p = 1, q = 2
//Output: 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lowest_Common_Ancestor_of_a_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Node root = solution.insert_level_order(new int?[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Console.ReadKey();
        }
    }
}
