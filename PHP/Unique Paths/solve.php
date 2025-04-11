<?php
$m = 3;
$n = 7;

/*Example 1:


Input: m = 3, n = 7
Output: 28
Example 2:

Input: m = 3, n = 2
Output: 3
Explanation: From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
1. Right -> Down -> Down
2. Down -> Down -> Right*/

function solve_unique_paths($m, $n) {
    $dp = array_fill(0, $m, array_fill(0, $n, 1));
    for ($i = 1; $i < $m; $i++)
    {
        for ($j = 1; $j < $n; $j++)
        {
            $dp[$i][$j] = $dp[$i - 1][$j] + $dp[$i][$j - 1];
        }
    }
    return $dp[$m - 1][$n - 1];
}

echo solve_unique_paths($m, $n);