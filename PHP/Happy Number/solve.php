<?php

$n = 19;

/*
Example 1:

Input: n = 19
Output: true
Explanation:
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1
Example 2:

Input: n = 2
Output: false
*/

function solve_happy_number($n) {
    $hash_map = array();
    while ($n != 1 && !in_array($n, $hash_map)) {
        $hash_map[] = $n;
        $new_n = 0;
        while ($n > 0) {
            $digit = $n % 10;
            $new_n += $digit * $digit;
            $n = floor($n / 10);
        }
        $n = $new_n;
    }
    return $n == 1;
}

echo solve_happy_number($n);    