"""
Example 1:


Input: n = 3
Output: 5
Explanation: The five different ways are show above.
Example 2:

Input: n = 1
Output: 1
"""


n = 3

def solve_domino_and_tromino_tiling(n):
    MOD = 10**9 + 7 
    if n == 0:
        return 1
    elif n == 1:
        return 1
    elif n == 2:
        return 2
    
    """
    dp[n-1]: đặt domino title dọc vào cuối
    dp[n-2]: đặt 2 domino title ngang
    2*sum_dp: tromino tile hình L xoay trái hoặc phải
    """
    dp = [0] * (n + 1)
    dp[0] = 1 #Ma trận 2x0 -> Có một cách 
    dp[1] = 1 #Ma trận 2x1 -> Có một cách để đặt 1 domino tile dọc
    dp[2] = 2 #Ma trận 2x2 -> Có 2 cách để đặt 2 domino tile dọc và 2 domino title ngang
    sum_dp = 1

    for i in range(3, n + 1):
        dp[i] = (dp[i - 1] + dp[i - 2] + 2 * sum_dp) % MOD
        sum_dp = (sum_dp + dp[i - 2]) % MOD
    return dp[n]