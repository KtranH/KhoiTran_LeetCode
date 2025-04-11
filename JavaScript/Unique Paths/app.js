const m = 3
const n = 7

/*Example 1:


Input: m = 3, n = 7
Output: 28
Example 2:

Input: m = 3, n = 2
Output: 3
Explanation: From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
1. Right -> Down -> Down
2. Down -> Down -> Right
3. Down -> Right -> Down*/

function solve_unique_paths(m, n) {
    const dp = Array.from({ length: m }, () => Array(n).fill(1));
    for (let i = 1; i < m; i++)
    {
        for (let j = 1; j < n; j++)
        {
            dp[i][j] = dp[i - 1][j] + dp[i][j - 1];
        }
    }
    return dp[m - 1][n - 1];
}

console.log(solve_unique_paths(m, n))