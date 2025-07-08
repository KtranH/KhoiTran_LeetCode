<?php

$nums = [100,4,200,1,3,2];

/*
Example 1:

Input: nums = [100,4,200,1,3,2]
Output: 4
Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
Example 2:

Input: nums = [0,3,7,2,5,8,4,6,0,1]
Output: 9
Example 3:

Input: nums = [1,0,1,2]
Output: 3
*/

function solve_longest_consecutive_sequence($nums) {
    $nums_map = array_flip(array_unique($nums));
    $longest_streak = 0;
    foreach ($nums_map as $num => $value) {
        if (!isset($nums_map[$num - 1])) {
            $current_num = $num;
            $current_streak = 1;
            while (isset($nums_map[$current_num + 1])) {
                $current_num += 1;
                $current_streak += 1;
            }
            $longest_streak = max($longest_streak, $current_streak);
        }
    }
    return $longest_streak;
}

print_r(solve_longest_consecutive_sequence($nums));
