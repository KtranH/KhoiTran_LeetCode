<?php

$triangle = [[2], [1,1], [1,100,1], [1,100,100,1]];

/*Example 1:

Input: triangle = [[2],[3,4],[6,5,7],[4,1,8,3]]
Output: 11
Explanation: The triangle looks like:
   2
  3 4
 6 5 7
4 1 8 3
The minimum path sum from top to bottom is 2 + 3 + 5 + 1 = 11 (underlined above).
Example 2:

Input: triangle = [[-10]]
Output: -10*/

function solve_triangle($triangle)
{
    $dp = $triangle;
    for ($i = count($triangle) - 2; $i >= 0; $i--)
    {
        for ($j = 0; $j <= $i; $j++)
        {
            $dp[$i][$j] += min($dp[$i + 1][$j], $dp[$i + 1][$j + 1]);
        }
    }
    return $dp[0][0];
}

var_dump(solve_triangle($triangle));
