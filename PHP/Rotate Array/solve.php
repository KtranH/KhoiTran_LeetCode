<?php

$nums = [1,2,3,4,5,6,7];
$k = 3;

/*
Example 1:

Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
Example 2:

Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]
*/

function solve_rotate_array(&$nums, $k) {
    $right = $k % count($nums);
    $nums = array_merge(array_slice($nums, - $right), array_slice($nums, 0, - $right));
    return $nums;
}

print_r(solve_rotate_array($nums, $k));

?>
