//Example 1:


//Input: root = [3, 9, 20, null, null, 15, 7]
//Output: 3
//Example 2:

//Input: root = [1, null, 2]
//Output: 2
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Depth_of_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int?[] val = { 3, 9, 20, null, null, 15, 7 };
            Node root = s.insert_level_order(val);
            Console.WriteLine(s.solve_maximum_depth_of_binary_tree(root));
            Console.ReadKey();
        }
    }
}
