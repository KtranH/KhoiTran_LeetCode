/*Example 1:

Input: n = 4
Output: 4
Explanation:
T_3 = 0 + 1 + 1 = 2
T_4 = 1 + 1 + 2 = 4
Example 2:

Input: n = 25
Output: 1389537*/

console.time("test_DP-1D");
const n = 4;

function solve_n_th_tribonacci_number(n) {
    if(n == 0) return 0;
    else if(n == 1 || n == 2) return 1;

    const dp = new Array(n + 1);
    dp[0] = 0;
    dp[1] = 1;
    dp[2] = 1;

    for(let i = 3; i <= n; i++)
    {
        dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
    }
    return dp[n];
}

console.log(solve_n_th_tribonacci_number(n));

console.timeEnd("test_DP-1D");
