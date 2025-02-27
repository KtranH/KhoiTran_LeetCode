//Example 1:


//Input: head = [1, 2, 3, 4, 5]
//Output: [5,4,3,2,1]
//Example 2:


//Input: head = [1, 2]
//Output: [2,1]
//Example 3:

//Input: head = []
//Output: []


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.append(1);
            s.append(2);
            s.append(3);
            s.append(4);
            s.append(5);
            s.printList(s.head);
            Console.WriteLine();
            s.reverse();
            s.printList(s.head);
            Console.ReadKey();
        }
    }
}
