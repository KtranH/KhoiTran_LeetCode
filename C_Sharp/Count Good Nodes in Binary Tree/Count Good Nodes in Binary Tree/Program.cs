//Example 1:



//Input: root = [3, 1, 4, 3, null, 1, 5]
//Output: 4
//Explanation: Nodes in blue are good.
//Root Node (3) is always a good node.
//Node 4 -> (3,4) is the maximum value in the path starting from the root.
//Node 5 -> (3,4,5) is the maximum value in the path
//Node 3 -> (3,1,3) is the maximum value in the path.
//Example 2:



//Input: root = [3, 3, null, 4, 2]
//Output: 3
//Explanation: Node 2-> (3, 3, 2) is not good, because "3" is higher than it.
//Example 3:

//Input: root = [1]
//Output: 1
//Explanation: Root is considered as good.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Good_Nodes_in_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int?[] values = {3, 1, 4, 3, null, 1, 5};
            Node root = solution.insert_level_order(values);
            Console.WriteLine(solution.solve_count_good_nodes_in_binary_tree(root));
            Console.ReadKey();
        }
    }
}
