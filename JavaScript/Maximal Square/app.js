const matrix = [
    ["1", "0", "1", "0", "0"],
    ["1", "0", "1", "1", "1"],
    ["1", "1", "1", "1", "1"],
    ["1", "0", "0", "1", "0"]
];

/*Example 1:


Input: matrix = [["1","0","1","0","0"],["1","0","1","1","1"],["1","1","1","1","1"],["1","0","0","1","0"]]
Output: 4
Example 2:


Input: matrix = [["0","1"],["1","0"]]
Output: 1
Example 3:

Input: matrix = [["0"]]
Output: 0*/

function solve_maximal_square(matrix) {
    const n = matrix.length;
    const m = matrix[0].length;
    const dp = Array.from({ length: n + 1 }, () => Array(m + 1).fill(0));
    let max_result = 0;
    for (let i = 1; i <= n; i++) {
        for (let j = 1; j <= m; j++) {
            if (matrix[i - 1][j - 1] === "1") {
                dp[i][j] = Math.min(dp[i - 1][j], Math.min(dp[i - 1][j - 1], dp[i][j - 1])) + 1;
                max_result = Math.max(max_result, dp[i][j]);
            }
        }
    }
    return max_result * max_result;
}

console.log(solve_maximal_square(matrix));
