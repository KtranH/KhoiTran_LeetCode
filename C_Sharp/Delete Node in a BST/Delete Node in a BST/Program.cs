//Example 1:


//Input: root = [5, 3, 6, 2, 4, null, 7], key = 3
//Output: [5,4,6,2,null,null,7]
//Explanation: Given key to delete is 3. So we find the node with value 3 and delete it.
//One valid answer is [5,4,6,2,null,null,7], shown in the above BST.
//Please notice that another valid answer is [5,2,6,null,4,null,7] and it's also accepted.

//Example 2:

//Input: root = [5, 3, 6, 2, 4, null, 7], key = 0
//Output: [5,3,6,2,4,null,7]
//Explanation: The tree does not contain a node with value = 0.
//Example 3:

//Input: root = [], key = 0
//Output: []

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete_Node_in_a_BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int?[] values = { 5, 3, 6, 2, 4, null, 7 };
            foreach (int value in values)
            {
                solution.insert(value);
            }
            Console.ReadKey();
        }
    }
}
