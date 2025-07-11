<?php

$intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]];
$newInterval = [4,8];

/*
Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
*/

function solve_insert_interval($intervals, $newInterval){
    array_push($intervals, $newInterval);
    usort($intervals, function($a, $b){
        return $a[0] - $b[0];
    });
    $result = [];
    $current = $intervals[0];
    for($i = 1; $i < count($intervals); $i++){
        if($intervals[$i][0] <= $current[1]){
            $current[1] = max($current[1], $intervals[$i][1]);
        }else{
            array_push($result, $current);
            $current = $intervals[$i];
        }
    }
    array_push($result, $current);
    return $result;
}

print_r(solve_insert_interval($intervals, $newInterval));