<?php

/*Example 1:


Input: n = 3
Output: 5
Explanation: The five different ways are show above.
Example 2:

Input: n = 1
Output: 1*/

$n = 3;

function solve_domino_and_tromino_tiling($n) {
    $MOD = 1000000007;
    if ($n === 0) return 1;
    if ($n === 1) return 1;
    if ($n === 2) return 2;

    $dp = array_fill(0, $n + 1, 0);
    $dp[0] = 1;
    $dp[1] = 1;
    $dp[2] = 2;
    $sumDp = 1;

    for ($i = 3; $i <= $n; $i++)
    {
        $dp[$i] = ($dp[$i - 1] + $dp[$i - 2] + 2 * $sumDp) % $MOD;
        $sumDp = ($sumDp + $dp[$i - 2]) % $MOD;
    }
    return $dp[$n];
}

print_r(solve_domino_and_tromino_tiling($n));
