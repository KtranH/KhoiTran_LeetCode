//Example 1:

//Input: rooms = [[1], [2], [3], []]
//Output: true
//Explanation:
//We visit room 0 and pick up key 1.
//We then visit room 1 and pick up key 2.
//We then visit room 2 and pick up key 3.
//We then visit room 3.
//Since we were able to visit every room, we return true.
//Example 2:

//Input: rooms = [[1, 3], [3, 0, 1], [2], [0]]
//Output: false
//Explanation: We can not enter room number 2 since the only key that unlocks it is in that room.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys_and_Rooms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.Write(solution.solve_keys_and_rooms());
            Console.ReadKey();
        }
    }
}
