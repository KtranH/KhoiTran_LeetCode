<?php

$nums = [2,3,1,2,4,3];
$target = 7;

/*
Example 1:

Input: nums = [2,3,1,2,4,3], target = 7
Output: 2
Explanation: The subarray [4,3] has the minimal length under the problem constraint.
Example 2:

Input: nums = [1,2,3,4,5], target = 11
Output: 0
*/

function solve_min_size_subarray_sum($nums, $target){
    $n = count($nums);
    $right = 0;
    $left = 0;
    $total = 0;
    $min_length = PHP_INT_MAX;
    while($right < $n){
        $total += $nums[$right];
        while($total >= $target){
            $tmp = $right - $left + 1;
            if($tmp < $min_length){
                $min_length = $tmp;
            }
            $total -= $nums[$left];
            $left++;
        }
        $right++;
    }
    return $min_length === PHP_INT_MAX ? 0 : $min_length;
}

print_r(solve_min_size_subarray_sum($nums, $target));
