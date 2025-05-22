using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Time_to_Buy_and_Sell_Stock
{
    internal class Solution
    {
        public int solve_best_time_to_buy_and_sell_stock(int[] prices)
        {
            int min_price = int.MaxValue;
            int max_profit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if(prices[i] < min_price)
                {
                    min_price = prices[i];
                }
                else if (prices[i] - min_price > max_profit)
                {
                    max_profit = prices[i] - min_price;
                }
            }
            return max_profit;
        }
    }
}
