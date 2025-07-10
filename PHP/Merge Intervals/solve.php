<?php

/*
Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
*/
function solve_merge_intervals($intervals) {
    array_multisort($intervals, SORT_ASC, $intervals);
    $result = [];
    $current = $intervals[0];
    for ($i = 1; $i < count($intervals); $i++) {
        if ($intervals[$i][0] <= $current[1]) {
            $current[1] = max($current[1], $intervals[$i][1]);
        } else {
            $result[] = $current;
            $current = $intervals[$i];
        }
    }
    $result[] = $current;
    return $result;
}

print_r(solve_merge_intervals([[1,3],[2,6],[8,10],[15,18]]));
