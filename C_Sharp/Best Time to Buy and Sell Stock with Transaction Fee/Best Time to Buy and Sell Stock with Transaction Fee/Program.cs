using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: prices = [1, 3, 2, 8, 4, 9], fee = 2
//Output: 8
//Explanation: The maximum profit can be achieved by:
//-Buying at prices[0] = 1
//- Selling at prices[3] = 8
//- Buying at prices[4] = 4
//- Selling at prices[5] = 9
//The total profit is ((8 - 1) - 2) + ((9 - 4) - 2) = 8.
//Example 2:

//Input: prices = [1, 3, 7, 5, 10, 3], fee = 3
//Output: 6

namespace Best_Time_to_Buy_and_Sell_Stock_with_Transaction_Fee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 1, 3, 2, 8, 4, 9 };
            int fee = 2;
            Solution solution = new Solution();
            int result = solution.solve_best_time_to_buy_and_sell_stock_with_transaction_fee(prices, fee);
            Console.WriteLine(result); 
            Console.ReadLine();
        }
    }
}
