grid = [[1,3,1],[1,5,1],[4,2,1]]

"""
Example 1:

Input: grid = [[1,3,1],[1,5,1],[4,2,1]]
Output: 7
Explanation: The path with the minimum possible sum is the path highlighted in red.
- Start at (0,0) with 0 points.
- Move to (0,1) with 3 points, so 0 + 3 = 3 points.
- Move to (1,1) with 5 points, so 3 + 5 = 8 points.
- Move to (1,2) with 1 point, so 8 + 1 = 9 points.
- Move to (2,2) with 1 point, so 9 + 1 = 10 points.

The total sum of points is 10, which is the minimum.
Example 2:

Input: grid = [[1,2,3],[4,5,6]]
Output: 12
Explanation: The minimum path sum is 1 + 2 + 3 + 6 = 12.
"""

def print_matrix(matrix):
    for row in matrix:
        for col in row:
            print(col, end=" ")
        print()

def solve_minimum_path_sum(grid):
    dp = [[0 for _ in range(len(grid[0]))] for _ in range(len(grid))]
    dp[0][0] = grid[0][0]
    for i in range(1, len(grid)):
        dp[i][0] = dp[i-1][0] + grid[i][0]
    for i in range(1, len(grid[0])):
        dp[0][i] = dp[0][i-1] + grid[0][i]
    print_matrix(dp)
    for i in range(1, len(grid)):
        for j in range(1, len(grid[0])):
            dp[i][j] = min(dp[i-1][j], dp[i][j-1]) + grid[i][j]
    return dp[-1][-1]

print(solve_minimum_path_sum(grid))