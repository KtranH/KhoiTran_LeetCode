﻿//Example 1:

//Input: flowerbed = [1, 0, 0, 0, 1], n = 1
//Output: true
//Example 2:

//Input: flowerbed = [1, 0, 0, 0, 1], n = 2
//Output: false

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Can_Place_Flowers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] flowered = { 0, 0, 1, 0, 1 };
            int n = 1;
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_can_place_flowers(flowered, n));
            Console.ReadKey();
        }
    }
}
