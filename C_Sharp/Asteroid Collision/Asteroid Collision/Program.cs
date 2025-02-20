//Example 1:

//Input: asteroids = [5, 10, -5]
//Output: [5,10]
//Explanation: The 10 and - 5 collide resulting in 10. The 5 and 10 never collide.
//Example 2:

//Input: asteroids = [8, -8]
//Output: []
//Explanation: The 8 and - 8 collide exploding each other.
//Example 3:

//Input: asteroids = [10, 2, -5]
//Output: [10]
//Explanation: The 2 and - 5 collide resulting in -5. The 10 and -5 collide resulting in 10.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroid_Collision
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] asteroids = { 5, 10, -5 };
            Solution solution = new Solution();
            int[] result = solution.solve_asteroid_collision(asteroids);
            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
