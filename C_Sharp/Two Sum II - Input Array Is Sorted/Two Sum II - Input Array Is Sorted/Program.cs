﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: numbers = [2, 7, 11, 15], target = 9
//Output: [1,2]
//Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2.We return [1, 2].
//Example 2:

//Input: numbers = [2, 3, 4], target = 6
//Output: [1,3]
//Explanation: The sum of 2 and 4 is 6. Therefore index1 = 1, index2 = 3.We return [1, 3].
//Example 3:

//Input: numbers = [-1, 0], target = -1
//Output: [1,2]
//Explanation: The sum of - 1 and 0 is -1. Therefore index1 = 1, index2 = 2.We return [1, 2].

namespace Two_Sum_II___Input_Array_Is_Sorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            Solution solution = new Solution();
            int[] result = solution.solve_two_sum(nums, target);
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
            Console.ReadKey();
        }
    }
}
