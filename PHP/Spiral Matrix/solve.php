<?php

$matrix = [[1,2,3],[4,5,6],[7,8,9]];

/*Example 1:


Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,2,3,6,9,8,7,4,5]
Example 2:


Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
Output: [1,2,3,4,8,12,11,10,9,5,6,7]
*/

function solve_spiral_matrix($matrix){
    $top = 0;
    $bottom = count($matrix) - 1;
    $left = 0;
    $right = count($matrix[0]) - 1;
    $result = [];
    while($top <= $bottom && $left <= $right){
        for($i = $left; $i <= $right; $i++){
            $result[] = $matrix[$top][$i];
        }
        $top++;
        for($i = $top; $i <= $bottom; $i++){
            $result[] = $matrix[$i][$right];
        }
        $right--;
        if($top <= $bottom){
            for($i = $right; $i >= $left; $i--){
                $result[] = $matrix[$bottom][$i];
            }
            $bottom--;
        }
        if($left <= $right){
            for($i = $bottom; $i >= $top; $i--){
                $result[] = $matrix[$i][$left];
            }
            $left++;
        }
    }
    return $result;
}

print_r(solve_spiral_matrix($matrix));
