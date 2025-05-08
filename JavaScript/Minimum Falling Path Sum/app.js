const matrix = [[2, 1, 3], [6, 5, 4], [7, 8, 9]]

/*Example 1:


Input: matrix = [[2,1,3],[6,5,4],[7,8,9]]
Output: 13
Explanation: There are two falling paths with a minimum sum as shown.
Example 2:


Input: matrix = [[-19,57],[-40,-5]]
Output: -59
Explanation: The falling path with a minimum sum is shown.*/

function solve_min_falling_path_sum(matrix) {
    const dp = matrix.slice();
    const n = matrix.length;
    for (let i = n - 2; i >= 0; i--) {
        for (let j = 0; j < n; j++) {
            if (j === 0) {
                dp[i][j] += Math.min(dp[i + 1][j], dp[i + 1][j + 1]);
            } else if (j === n - 1) {
                dp[i][j] += Math.min(dp[i + 1][j - 1], dp[i + 1][j]);
            } else {
                dp[i][j] += Math.min(dp[i + 1][j - 1], Math.min(dp[i + 1][j], dp[i + 1][j + 1]));
            }
        }
    }
    return Math.min(...dp[0]);
}

console.log(solve_min_falling_path_sum(matrix));