using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: temperatures = [73, 74, 75, 71, 69, 72, 76, 73]
//Output: [1,1,4,2,1,1,0,0]
//Example 2:

//Input: temperatures = [30, 40, 50, 60]
//Output: [1,1,1,0]
//Example 3:

//Input: temperatures = [30, 60, 90]
//Output: [1,1,0]

namespace Daily_Temperatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] temperatures = { 73, 74, 75, 71, 69, 72, 76, 73 };
            Solution solution = new Solution();
            int[] result = solution.solve_daily_temperatures(temperatures);
            Console.WriteLine(string.Join(", ", result));
            Console.ReadLine();
        }
    }
}
