n = 4

"""
Example 1:

Input: n = 4
Output: 4
Explanation:
T_3 = 0 + 1 + 1 = 2
T_4 = 1 + 1 + 2 = 4
Example 2:

Input: n = 25
Output: 1389537
"""

def solve_n_th_tribonacci_number(n):
    if n == 0:
        return 0
    elif n == 1:
        return 1
    elif n == 2:
        return 1

    dp = [0] * (n + 1)
    dp[0] = 0
    dp[1] = 1
    dp[2] = 1

    for i in range(3, n + 1):
        dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3]
    return dp[n]

print(solve_n_th_tribonacci_number(n))