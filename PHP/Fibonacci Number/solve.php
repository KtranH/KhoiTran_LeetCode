<?php

/*Example 1:

Input: n = 2
Output: 1
Explanation: F(2) = F(1) + F(0) = 1 + 0 = 1.
Example 2:

Input: n = 3
Output: 2
Explanation: F(3) = F(2) + F(1) = 1 + 1 = 2.
Example 3:

Input: n = 4
Output: 3
Explanation: F(4) = F(3) + F(2) = 2 + 1 = 3.*/

$n = 2;

function solve_fibonacci_number($n) {
    if ($n === 0) {
        return 0;
    } else if ($n === 1) {
        return 1;
    }
    $dp = array_fill(0, $n + 1, 0);
    $dp[1] = 1;
    $dp[2] = 1;
    for ($i = 3; $i <= $n; $i++) {
        $dp[$i] = $dp[$i - 1] + $dp[$i - 2];
    }
    return $dp[$n];
}