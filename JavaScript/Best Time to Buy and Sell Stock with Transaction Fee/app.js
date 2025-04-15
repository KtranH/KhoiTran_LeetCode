const prices = [1,3,2,8,4,9];
const fee = 2;

/*Example 1:

Input: prices = [1,3,2,8,4,9], fee = 2
Output: 8
Explanation: The maximum profit can be achieved by:
- Buying at prices[0] = 1
- Selling at prices[3] = 8
- Buying at prices[4] = 4
- Selling at prices[5] = 9
The total profit is ((8 - 1) - 2) + ((9 - 4) - 2) = 8.
Example 2:

Input: prices = [1,3,7,5,10,3], fee = 3
Output: 6*/

function solveBestTimeToBuyAndSellStockWithTransactionFee(prices, fee) {
    let n = prices.length;
    let cash = 0;
    let hold = -prices[0];
    for (let i = 1; i < n; i++)
    {
        cash = Math.max(cash, hold + prices[i] - fee);
        hold = Math.max(hold, cash - prices[i]);
    }
    return cash;
}