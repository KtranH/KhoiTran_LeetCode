//Example 1:


//Input: head = [5, 4, 2, 1]
//Output: 6
//Explanation:
//Nodes 0 and 1 are the twins of nodes 3 and 2, respectively. All have twin sum = 6.
//There are no other nodes with twins in the linked list.
//Thus, the maximum twin sum of the linked list is 6. 
//Example 2:


//Input: head = [4, 2, 2, 3]
//Output: 7
//Explanation:
//The nodes with twins present in this linked list are:
//-Node 0 is the twin of node 3 having a twin sum of 4 + 3 = 7.
//- Node 1 is the twin of node 2 having a twin sum of 2 + 2 = 4.
//Thus, the maximum twin sum of the linked list is max(7, 4) = 7. 
//Example 3:


//Input: head = [1, 100000]
//Output: 100001
//Explanation:
//There is only one node with a twin in the linked list having twin sum of 1 + 100000 = 100001.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Twin_Sum_of_a_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.append(5);
            s.append(4);
            s.append(2);
            s.append(1);
            Console.WriteLine(s.solve_maximum_twin_sum_of_a_linked_list());
            Console.ReadKey();
        }
    }
}
