using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Stock_Span
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution stockSpan = new Solution();
            Console.WriteLine(stockSpan.Next(100)); // Output: 1
            Console.WriteLine(stockSpan.Next(80));  // Output: 1
            Console.WriteLine(stockSpan.Next(60));  // Output: 1
            Console.WriteLine(stockSpan.Next(70));  // Output: 2
            Console.WriteLine(stockSpan.Next(60));  // Output: 1
            Console.WriteLine(stockSpan.Next(75));  // Output: 4
            Console.WriteLine(stockSpan.Next(85));  // Output: 6
            Console.ReadKey();
        }
    }
}
