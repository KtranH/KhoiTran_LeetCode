<?php

/*Example 1:

Input: n = 10, pick = 6
Output: 6
Example 2:

Input: n = 1, pick = 1
Output: 1
Example 3:

Input: n = 2, pick = 1
Output: 1*/

$n = 10;

function guess($num) {
    return 0;
}

function solve_guess_number($n) {
    $left = 1;
    $right = $n;
    while ($left <= $right) {
        $mid = floor(($left + $right) / 2);
        $result = guess($mid);
        if ($result === 0) {
            return $mid;
        } elseif ($result === -1) {
            $right = $mid - 1;
        } else {
            $left = $mid + 1;
        }
    }   
    return -1;
}