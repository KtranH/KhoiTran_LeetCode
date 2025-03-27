//Example 1:

//Input: costs = [17, 12, 10, 2, 7, 2, 11, 20, 8], k = 3, candidates = 4
//Output: 11
//Explanation: We hire 3 workers in total. The total cost is initially 0.
//- In the first hiring round we choose the worker from [17, 12, 10, 2, 7, 2, 11, 20, 8].The lowest cost is 2, and we break the tie by the smallest index, which is 3. The total cost = 0 + 2 = 2.
//- In the second hiring round we choose the worker from [17, 12, 10, 7, 2, 11, 20, 8].The lowest cost is 2 (index 4). The total cost = 2 + 2 = 4.
//- In the third hiring round we choose the worker from [17, 12, 10, 7, 11, 20, 8].The lowest cost is 7 (index 3). The total cost = 4 + 7 = 11. Notice that the worker with index 3 was common in the first and last four workers.
//The total hiring cost is 11.
//Example 2:

//Input: costs = [1, 2, 4, 1], k = 3, candidates = 3
//Output: 4
//Explanation: We hire 3 workers in total. The total cost is initially 0.
//- In the first hiring round we choose the worker from [1, 2, 4, 1].The lowest cost is 1, and we break the tie by the smallest index, which is 0. The total cost = 0 + 1 = 1. Notice that workers with index 1 and 2 are common in the first and last 3 workers.
//- In the second hiring round we choose the worker from [2, 4, 1].The lowest cost is 1 (index 2). The total cost = 1 + 1 = 2.
//- In the third hiring round there are less than three candidates. We choose the worker from the remaining workers [2, 4].The lowest cost is 2 (index 0). The total cost = 2 + 2 = 4.
//The total hiring cost is 4.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Cost_to_Hire_K_Workers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_total_cost_to_hire_k_workers(solution.costs, solution.k, solution.candidates));
            Console.ReadKey();
        }
    }
}
