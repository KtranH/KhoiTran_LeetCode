using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:


//Input: m = 3, n = 7
//Output: 28
//Example 2:

//Input: m = 3, n = 2
//Output: 3
//Explanation: From the top - left corner, there are a total of 3 ways to reach the bottom-right corner:
//1.Right->Down->Down
//2.Down->Down->Right
//3.Down->Right->Down

namespace Unique_Paths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int m = 3, n = 7;
            Console.WriteLine(s.solve_unique_paths(m, n)); 
            Console.ReadLine();
        }
    }
}
