//Example 1:


//Input: head = [1, 2, 3, 4, 5]
//Output: [1,3,5,2,4]
//Example 2:


//Input: head = [2, 1, 3, 5, 6, 4, 7]
//Output: [2,3,6,7,1,5,4]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.append(1);
            solution.append(2);
            solution.append(3);
            solution.solve_odd_even_linked_list();
            solution.display();
            Console.ReadKey();
        }
    }
}
