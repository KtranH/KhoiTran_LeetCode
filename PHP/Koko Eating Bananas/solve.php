<?php

/*Example 1:

Input: piles = [3,6,7,11], h = 8
Output: 4
Example 2:

Input: piles = [30,11,23,4,20], h = 5
Output: 30
Example 3:

Input: piles = [30,11,23,4,20], h = 6
Output: 23*/

$piles = [3,6,7,11];
$h = 8;

function solve_koko_eating_piles($piles, $h) {
    $left = 1;
    $right = max($piles);
    while ($left < $right) {
        $mid = floor(($left + $right) / 2);
        $hours = 0;
        for ($i = 0; $i < count($piles); $i++) {
            $hours += ceil($piles[$i] / $mid);
        }
        if ($hours > $h) {
            $left = $mid + 1;
        } else {
            $right = $mid;
        }
    }
    return $left;    
}

echo solve_koko_eating_piles($piles, $h);

