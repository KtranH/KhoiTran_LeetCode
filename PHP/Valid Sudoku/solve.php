<?php

$board = [
    ["5","3",".",".","7",".",".",".","."],
    ["6",".",".","1","9","5",".",".","."],
    [".","9","8",".",".",".",".","6","."],
    ["8",".",".",".","6",".",".",".","3"],
    ["4",".",".","8",".","3",".",".","1"],
    ["7",".",".",".","2",".",".",".","6"],
    [".","6",".",".",".",".","2","8","."],
    [".",".",".","4","1","9",".",".","5"],
    [".",".",".",".","8",".",".","7","9"]
];

function solve_valid_sudoku($board) {
    $rows = array_fill(0, 9, array());
    $cols = array_fill(0, 9, array());
    $boxes = array_fill(0, 9, array());

    for ($i = 0; $i < 9; $i++) {
        for ($j = 0; $j < 9; $j++) {
            if ($board[$i][$j] != ".") {
                $boxIndex = floor($i / 3) * 3 + floor($j / 3);
                if (in_array($board[$i][$j], $rows[$i]) || in_array($board[$i][$j], $cols[$j]) || in_array($board[$i][$j], $boxes[$boxIndex])) {
                    return false;
                }
                $rows[$i][] = $board[$i][$j];
                $cols[$j][] = $board[$i][$j];
                $boxes[$boxIndex][] = $board[$i][$j];
            }
        }
    }
    return true;
}

print_r(solve_valid_sudoku($board));
