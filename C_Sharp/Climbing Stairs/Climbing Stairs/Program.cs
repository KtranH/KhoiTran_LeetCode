﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Example 1:

//Input: n = 2
//Output: 2
//Explanation: There are two ways to climb to the top.
//1. 1 step + 1 step
//2. 2 steps
//Example 2:

//Input: n = 3
//Output: 3
//Explanation: There are three ways to climb to the top.
//1. 1 step + 1 step + 1 step
//2. 1 step + 2 steps
//3. 2 steps + 1 step

namespace Climbing_Stairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine("Enter the number of stairs:");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = solution.solve_climbing_stairs(n);
            Console.WriteLine($"Number of ways to climb {n} stairs: {result}");
            Console.ReadKey();
        }
    }
}
