<?php

$matrix = [[1,1,1],[1,0,1],[1,1,1]];

/*
Example 1:

Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
Output: [[1,0,1],[0,0,0],[1,0,1]]
Example 2:

Input: matrix = [[0,1,2,0],[3,4,5,2],[1,3,1,5]]
Output: [[0,0,0,0],[0,4,5,0],[0,3,1,0]]
*/ 

function solve_set_matrix_zeroes($matrix) {
    $n = count($matrix);
    $m = count($matrix[0]);
    
    $firstRow = false;
    $firstCol = false;

    for($i = 0; $i < $n; $i++) {
        if($matrix[$i][0] == 0) {
            $firstCol = true;
            break;
        }
    }

    for($j = 0; $j < $m; $j++) {
        if($matrix[0][$j] == 0) {
            $firstRow = true;
            break;
        }
    }

    for($i = 1; $i < $n; $i++) {
        for($j = 1; $j < $m; $j++) {
            if($matrix[$i][$j] == 0) {
                $matrix[$i][0] = 0;
                $matrix[0][$j] = 0;
            }
        }
    }

    for($i = 1; $i < $n; $i++) {
        for($j = 1; $j < $m; $j++) {
            if($matrix[$i][0] == 0 || $matrix[0][$j] == 0) {
                $matrix[$i][$j] = 0;
            }
        }
    }

    if($firstRow) {
        for($j = 0; $j < $m; $j++) {
            $matrix[0][$j] = 0;
        }
    }

    if($firstCol) {
        for($i = 0; $i < $n; $i++) {
            $matrix[$i][0] = 0;
        }
    }

    return $matrix;
}

print_r(solve_set_matrix_zeroes($matrix));
