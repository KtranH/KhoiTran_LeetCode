﻿//using System.Security.Cryptography;

//Example 1:

//Input: candies = [2, 3, 5, 1, 3], extraCandies = 3
//Output: [true,true,true,false,true] 
//Explanation: If you give all extraCandies to:
//-Kid 1, they will have 2 + 3 = 5 candies, which is the greatest among the kids.
//- Kid 2, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
//- Kid 3, they will have 5 + 3 = 8 candies, which is the greatest among the kids.
//- Kid 4, they will have 1 + 3 = 4 candies, which is not the greatest among the kids.
//- Kid 5, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
//Example 2:

//Input: candies = [4, 2, 1, 1, 2], extraCandies = 1
//Output: [true,false,false,false,false] 
//Explanation: There is only 1 extra candy.
//Kid 1 will always have the greatest number of candies, even if a different kid is given the extra candy.
//Example 3:

//Input: candies = [12, 1, 12], extraCandies = 10
//Output: [true,false,true]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_With_the_Greatest_Number_of_Candies
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 3;

            bool[] result = solution.solved_kids_the_greatest_number_of_candies(candies, extraCandies);
            Console.WriteLine("result: " + string.Join(", ", result));
            Console.ReadKey();
        }
    }
}
