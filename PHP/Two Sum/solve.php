<?php

$nums = [2,7,11,15];
$target = 9;

/*Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]*/

function solve_two_sum($nums, $target) {
    $map = array();
    for ($i = 0; $i < count($nums); $i++) {
        $complement = $target - $nums[$i];
        if (array_key_exists($complement, $map)) {
            return array($map[$complement], $i);
        }
        $map[$nums[$i]] = $i;
    }
    return array();
}

print_r(solve_two_sum($nums, $target));
