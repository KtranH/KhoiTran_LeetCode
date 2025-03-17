//Example 1:


//Input: isConnected = [[1, 1, 0], [1, 1, 0], [0, 0, 1]]
//Output: 2
//Example 2:


//Input: isConnected = [[1, 0, 0], [0, 1, 0], [0, 0, 1]]
//Output: 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Provinces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_number_of_provinces());
            Console.ReadKey();
        }
    }
}
