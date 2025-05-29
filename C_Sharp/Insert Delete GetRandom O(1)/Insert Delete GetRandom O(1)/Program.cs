using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input
//["RandomizedSet", "insert", "remove", "insert", "getRandom", "remove", "insert", "getRandom"]
//[[], [1], [2], [2], [], [1], [2], []]
//Output
//[null, true, false, true, 2, true, false, 2]

//Explanation
//RandomizedSet randomizedSet = new RandomizedSet();
//randomizedSet.insert(1); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
//randomizedSet.remove(2); // Returns false as 2 does not exist in the set.
//randomizedSet.insert(2); // Inserts 2 to the set, returns true. Set now contains [1,2].
//randomizedSet.getRandom(); // getRandom() should return either 1 or 2 randomly.
//randomizedSet.remove(1); // Removes 1 from the set, returns true. Set now contains [2].
//randomizedSet.insert(2); // 2 was already in the set, so return false.
//randomizedSet.getRandom(); // Since 2 is the only number in the set, getRandom() will always return 2.

namespace Insert_Delete_GetRandom_O_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.Insert(1)); // true
            Console.WriteLine(solution.Insert(2)); // true
            Console.WriteLine(solution.Remove(1)); // true
            Console.WriteLine(solution.GetRandom()); // 2 (or 1 if it was not removed)
            Console.WriteLine(solution.Insert(3)); // true
            Console.WriteLine(solution.Remove(2)); // true
            Console.WriteLine(solution.GetRandom()); // 3 (or 2 if it was not removed)
        }
    }
}
