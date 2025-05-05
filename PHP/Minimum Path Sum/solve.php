<?php

/*Example 1:

Input: grid = [[1,3,1],[1,5,1],[4,2,1]]
Output: 7
Explanation: Because the path 1 → 3 → 1 → 1 → 1 minimizes the sum.
Example 2:

Input: grid = [[1,2,3],[4,5,6]]
Output: 12*/

$grid = [[1, 3, 1], [1, 5, 1], [4, 2, 1]];

function solve_minimum_path_sum($grid)
{
    $dp = array_fill(0, count($grid), array_fill(0, count($grid[0]), 0));
    $dp[0][0] = $grid[0][0];
    for ($i = 1; $i < count($grid); $i++)
    {
        $dp[$i][0] = $dp[$i - 1][0] + $grid[$i][0];
    }
    for ($i = 1; $i < count($grid[0]); $i++)
    {
        $dp[0][$i] = $dp[0][$i - 1] + $grid[0][$i];
    }
    for ($i = 1; $i < count($grid); $i++)
    {
        for ($j = 1; $j < count($grid[0]); $j++)
        {
            $dp[$i][$j] = min($dp[$i - 1][$j], $dp[$i][$j - 1]) + $grid[$i][$j];
        }
    }
    return $dp[count($grid) - 1][count($grid[0]) - 1];
}