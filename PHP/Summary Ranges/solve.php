<?php

$nums = [0,2,3,4,6,8,9];

/*
Example 1:

Input: nums = [0,1,2,4,5,7]
Output: ["0->2","4->5","7"]
Explanation: The ranges are:
[0,2] --> "0->2"
[4,5] --> "4->5"
[7,7] --> "7"
Example 2:

Input: nums = [0,2,3,4,6,8,9]
Output: ["0","2->4","6","8->9"]
Explanation: The ranges are:
[0,0] --> "0"
[2,4] --> "2->4"
[6,6] --> "6"
[8,9] --> "8->9"
*/

function solve_summary_ranges($nums){
    $n = count($nums);
    if($n === 0) return [];
    $result = [];
    $start = $nums[0];
    for($i = 1; $i < $n; $i++){
        if($nums[$i] !== $nums[$i - 1] + 1){
            $end = $nums[$i - 1];
            if($start === $end){
                $result[] = strval($start);
            }else{
                $result[] = strval($start) . "->" . strval($end);
            }
            $start = $nums[$i];
        }
    }
    if($start === $nums[$n - 1]){
        $result[] = strval($start);
    }else{
        $result[] = strval($start) . "->" . strval($nums[$n - 1]);
    }
    return $result;
}

print_r(solve_summary_ranges($nums));
