//Example 1:
//Input: height = [1, 8, 6, 2, 5, 4, 8, 3, 7]
//Output: 49
//Explanation: The above vertical lines are represented by array [1, 8, 6, 2, 5, 4, 8, 3, 7].In this case, the max area of water(blue section) the container can contain is 49.
//Example 2:

//Input: height = [1, 1]
//Output: 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container_With_Most_Water
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Solution s = new Solution();
            Console.WriteLine(s.solve_container_with_most_water(height));
            Console.ReadKey();
        }
    }
}
