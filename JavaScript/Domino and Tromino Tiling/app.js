/*Example 1:


Input: n = 3
Output: 5
Explanation: The five different ways are show above.
Example 2:

Input: n = 1
Output: 1*/

const n = 3

function solve_domino_and_tromino_tiling(n) {
    const MOD = 1000000007;
    if (n === 0) return 1;
    if (n === 1) return 1;
    if (n === 2) return 2;

    const dp = new Array(n + 1);
    dp[0] = 1;
    dp[1] = 1;
    dp[2] = 2;
    let sumDp = 1;

    for (let i = 3; i <= n; i++)
    {
        dp[i] = (dp[i - 1] + dp[i - 2] + 2 * sumDp) % MOD;
        sumDp = (sumDp + dp[i - 2]) % MOD;
    }
    return dp[n];
}

console.log(solve_domino_and_tromino_tiling(n));