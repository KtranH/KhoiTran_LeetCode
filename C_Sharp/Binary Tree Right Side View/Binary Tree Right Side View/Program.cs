//Example 1:

//Input: root = [1, 2, 3, null, 5, null, 4]

//Output: [1,3,4]

//Explanation:



//Example 2:

//Input: root = [1, 2, 3, 4, null, null, null, 5]

//Output: [1,3,4,5]

//Explanation:



//Example 3:

//Input: root = [1, null, 3]

//Output: [1,3]

//Example 4:

//Input: root = []

//Output: []

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Right_Side_View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int?[] values = { 1, 2, 3, null, 5, null, 4 };
            Node root = solution.insert_level_order(values);
            List<int> result = solution.solve_binary_tree_right_side_view(root);
            foreach (int item in result)
            {
                Console.Write(item + " ");
            }    
            Console.ReadKey();
        }
    }
}
