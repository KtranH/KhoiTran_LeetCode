<?php

/*Example 1:

Input: nums = [2,2,1]

Output: 1

Example 2:

Input: nums = [4,1,2,1,2]

Output: 4

Example 3:

Input: nums = [1]

Output: 1*/

$nums = [2, 2, 1];

function solve_single_number($nums) {
    $result = 0;
    foreach ($nums as $num) {
        $result ^= $num;
    }
    return $result;
}
