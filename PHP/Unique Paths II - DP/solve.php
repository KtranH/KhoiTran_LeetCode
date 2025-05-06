<?php

$obstacleGrid = [[0,0,0],[0,1,0],[0,0,0]];

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

function solve_unique_paths_ii($obstacleGrid)
{
    $m = count($obstacleGrid);
    $n = count($obstacleGrid[0]);
    $dp = array_fill(0, $m + 1, array_fill(0, $n + 1, 0));
    $dp[1][1] = 1;
    for ($i = 1; $i <= $m; $i++)
    {
        for ($j = 1; $j <= $n; $j++)
        {
            if ($obstacleGrid[$i - 1][$j - 1] === 1)
            {
                $dp[$i][$j] = 0;
            }
            else
            {
                if ($i > 1)
                {
                    $dp[$i][$j] += $dp[$i - 1][$j];
                }
                if ($j > 1)
                {
                    $dp[$i][$j] += $dp[$i][$j - 1];
                }
            }
        }
    }
    return $dp[$m][$n];
}

var_dump(solve_unique_paths_ii($obstacleGrid));
