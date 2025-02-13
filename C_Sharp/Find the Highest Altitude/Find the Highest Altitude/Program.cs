using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Highest_Altitude
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] gain = new int[] { -5, 1, 5, 0, -7 };
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_find_the_highest_altitude(gain));
            Console.ReadKey();
        }
    }
}
