using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Level_Sum_of_a_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int?[] values = { 3, 9, 20, null, null, 15, 7 };
            Node root = solution.insert_level_order(values);
            Console.WriteLine(solution.solve_maximum_level_sum(root));
            Console.ReadKey();
        }
    }
}
