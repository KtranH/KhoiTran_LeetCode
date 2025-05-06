const obstacleGrid = [[0,0,0],[0,1,0],[0,0,0]];

/*Example 1:


Input: obstacleGrid = [[0,0,0],[0,1,0],[0,0,0]]
Output: 2
Explanation: There is one obstacle in the middle of the 3x3 grid above.
There are two ways to reach the bottom-right corner:
1. Right -> Right -> Down -> Down
2. Down -> Down -> Right -> Right
Example 2:


Input: obstacleGrid = [[0,1],[0,0]]
Output: 1*/

function solve_unique_paths_ii(obstacleGrid) {
    let n = obstacleGrid.length;
    let m = obstacleGrid[0].length;
    let dp = Array.from({ length: n + 1 }, () => Array(m + 1).fill(0));
    dp[1][1] = 1;
    for (let i = 1; i <= n; i++) {
        for (let j = 1; j <= m; j++) {
            if (obstacleGrid[i - 1][j - 1] === 1) {
                dp[i][j] = 0;
            } else {
                if (i > 1) {
                    dp[i][j] += dp[i - 1][j];
                }
                if (j > 1) {
                    dp[i][j] += dp[i][j - 1];
                }
            }
        }
    }
    return dp[n][m];
}

console.log(solve_unique_paths_ii(obstacleGrid));