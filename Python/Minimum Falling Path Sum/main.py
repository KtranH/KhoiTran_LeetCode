matrix = [[2,1,3], [6,5,4], [7,8,9]]

"""
Example 1:


Input: matrix = [[2,1,3],[6,5,4],[7,8,9]]
Output: 13
Explanation: There are two falling paths with a minimum sum as shown.
Example 2:


Input: matrix = [[-19,57],[-40,-5]]
Output: -59
Explanation: The falling path with a minimum sum is shown.
"""

def solve_min_falling_path_sum(matrix):
    dp = matrix[:]
    n = len(matrix)
    for i in range(n - 2, -1, -1):
        for j in range(n):
            if j == 0:
                dp[i][j] += min(dp[i + 1][j], dp[i + 1][j + 1])
            elif j == n - 1:
                dp[i][j] += min(dp[i + 1][j], dp[i + 1][j - 1])
            else:
                dp[i][j] += min(dp[i + 1][j], dp[i + 1][j - 1], dp[i + 1][j + 1])
    return min(dp[0])

print(solve_min_falling_path_sum(matrix))