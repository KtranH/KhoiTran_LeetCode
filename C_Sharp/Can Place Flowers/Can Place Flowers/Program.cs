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
            Console.WriteLine(solution.slove_can_place_flowers(flowered, n));
            Console.ReadKey();
        }
    }
}
