"""
Example 1:

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
Output: 6
"""
prices = [1,3,2,8,4,9]
fee = 2
#v1
def solve_best_time_to_buy_and_sell_stock_with_transaction_fee(prices, fee):
    n = len(prices)
    dp = [[0] * 2 for _ in range(n)]
    dp[0][0] = 0 # giữ nguyên hoặc bán cổ phiếu đang có và trừ đi chi phí
    dp[0][1] = -prices[0] # giữ cổ phiếu hoặc mua mới
    for i in range(1, n):
        dp[i][0] = max(dp[i - 1][0], dp[i - 1][1] + prices[i] - fee)
        dp[i][1] = max(dp[i - 1][1], dp[i - 1][0] - prices[i])
    return dp[n - 1][0]
#v2
def solve_best_time_to_buy_and_sell_stock_with_transaction_fee_v2(prices, fee):
    n = len(prices)
    cash = 0 #tiền hiện có
    hold = -prices[0] #cổ phiếu hiện có
    for i in range(1, n):
        cash = max(cash, hold + prices[i] - fee)
        hold = max(hold, cash - prices[i])
    return cash