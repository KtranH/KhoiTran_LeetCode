const grid = [[1,3,1],[1,5,1],[4,2,1]];

/*Example 1:


Input: grid = [[1,3,1],[1,5,1],[4,2,1]]
Output: 7
Explanation: Because the path 1 → 3 → 1 → 1 → 1 minimizes the sum.
Example 2:

Input: grid = [[1,2,3],[4,5,6]]
Output: 12*/

function solve_minimum_path_sum(grid)
{
    let dp = Array.from({length: grid.length}, () => Array(grid[0].length).fill(0));
    dp[0][0] = grid[0][0];
    for(let i = 1; i < grid.length; i++)
    {
        dp[i][0] = dp[i - 1][0] + grid[i][0];
    }
    for(let i = 1; i < grid[0].length; i++)
    {
        dp[0][i] = dp[0][i - 1] + grid[0][i];
    }
    for(let i = 1; i < grid.length; i++)
    {
        for(let j = 1; j < grid[0].length; j++)
        {
            dp[i][j] = Math.min(dp[i - 1][j], dp[i][j - 1]) + grid[i][j];
        }
    }
    return dp[grid.length - 1][grid[0].length - 1];
}

console.log(solve_minimum_path_sum(grid));
