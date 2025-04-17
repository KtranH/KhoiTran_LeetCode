using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: n = 2
//Output: [0,1,1]
//Explanation:
//0-- > 0
//1-- > 1
//2-- > 10
//Example 2:

//Input: n = 5
//Output: [0,1,1,2,1,2]
//Explanation:
//0-- > 0
//1-- > 1
//2-- > 10
//3-- > 11
//4-- > 100
//5-- > 101

namespace Counting_Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int n = 5;
            int[] result = solution.slove_counting_bits(n);
            Console.WriteLine(string.Join(", ", result));
            Console.ReadLine();
        }
    }
}
