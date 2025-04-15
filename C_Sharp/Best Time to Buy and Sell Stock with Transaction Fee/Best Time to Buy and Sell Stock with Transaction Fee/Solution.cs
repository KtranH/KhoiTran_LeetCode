using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Time_to_Buy_and_Sell_Stock_with_Transaction_Fee
{
    internal class Solution
    {
        public int solve_best_time_to_buy_and_sell_stock_with_transaction_fee(int[] prices, int fee)
        {
            int n = prices.Length;
            int cash = 0;
            int hold = -prices[0];
            for (int i = 1; i < n; i++)
            {
                cash = Math.Max(cash, hold + prices[i] - fee);
                hold = Math.Max(hold, cash - prices[i]);
            }
            return cash;
        }
    }
}
