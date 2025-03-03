//Example 1:


//Input: root1 = [3, 5, 1, 6, 2, 9, 8, null, null, 7, 4], root2 = [3, 5, 1, 6, 7, 4, 2, null, null, null, null, null, null, 9, 8]
//Output: true
//Example 2:


//Input: root1 = [1, 2, 3], root2 = [1, 3, 2]
//Output: false

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaf_Similar_Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Node root1 = s.insert_level_order(new int?[] { 3, 5, 1, 6, 2, 9, 8, null, null, 7, 4 });
            Node root2 = s.insert_level_order(new int?[] { 3, 5, 1, 6, 7, 4, 2, null, null, null, null, null, null, 9, 8 });
            Console.WriteLine(s.solve_leaf_similar_trees(root1, root2));
            Console.ReadKey();
        }
    }
}
