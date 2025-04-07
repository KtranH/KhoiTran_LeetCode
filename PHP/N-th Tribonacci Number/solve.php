<?php

$n = 4;

function solve_n_th_tribonacci_number($n) {
    if($n == 0) return 0;
    else if($n == 1 || $n == 2) return 1;

    $dp = array_fill(0, $n + 1, 0);
    $dp[0] = 0;
    $dp[1] = 1;
    $dp[2] = 1;

    for($i = 3; $i <= $n; $i++)
    {
        $dp[$i] = $dp[$i - 1] + $dp[$i - 2] + $dp[$i - 3];
    }
    return $dp[$n];
}

print_r(solve_n_th_tribonacci_number($n));
