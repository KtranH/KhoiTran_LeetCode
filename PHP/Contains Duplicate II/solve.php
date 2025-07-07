<?php

$nums = [1,2,3,1];
$k = 3;

/*
Example 1:

Input: nums = [1,2,3,1], k = 3
Output: true
Example 2:

Input: nums = [1,0,1,1], k = 1
Output: true
Example 3:

Input: nums = [1,2,3,1,2,3], k = 2
Output: false
*/

function solve_contains_duplicate_ii($nums, $k) {
    $hash_map = array();
    for ($i = 0; $i < count($nums); $i++) {
        if (array_key_exists($nums[$i], $hash_map)) {
            if ($i - $hash_map[$nums[$i]] <= $k) {
                return true;
            }
        }
        $hash_map[$nums[$i]] = $i;
    }
    return false;
}

echo solve_contains_duplicate_ii($nums, $k);