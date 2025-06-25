<?php

$board = [[0,1,0],[0,0,1],[1,1,1],[0,0,0]];

/*
Example 1:

Input: board = [[0,1,0],[0,0,1],[1,1,1],[0,0,0]]
Output: [[0,0,0],[0,0,0],[1,1,1],[0,0,0]]
Example 2:

Input: board = [[1,1,0],[1,0,1],[0,1,1]]
Output: [[1,1,0],[1,0,1],[0,1,1]]
*/

function solve_game_of_life($board) {
    $n = count($board);
    $m = count($board[0]);
    $board_copy = $board;
    $direction = [
        [-1, -1], [-1, 0], [-1, 1],
        [0, -1],           [0, 1],
        [1, -1],  [1, 0],  [1, 1]
    ];
    for ($i = 0; $i < $n; $i++) {
        for ($j = 0; $j < $m; $j++) {
            $live = 0;
            for ($k = 0; $k < 8; $k++) {
                $x = $i + $direction[$k][0];
                $y = $j + $direction[$k][1];
                if ($x >= 0 && $x < $n && $y >= 0 && $y < $m && $board_copy[$x][$y] == 1)
                    $live++;
            }
            if ($board_copy[$i][$j] == 1 && ($live < 2 || $live > 3))
                $board[$i][$j] = 0;
            else if ($board_copy[$i][$j] == 0 && $live == 3)
                $board[$i][$j] = 1;
        }
    }
    return $board;
}  

print_r(solve_game_of_life($board));
