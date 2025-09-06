<?php

/*
Example 1:

Input: grid = [
  ["1","1","1","1","0"],
  ["1","1","0","1","0"],
  ["1","1","0","0","0"],
  ["0","0","0","0","0"]
]
Output: 1
Example 2:

Input: grid = [
  ["1","1","0","0","0"],
  ["1","1","0","0","0"],
  ["0","0","1","0","0"],
  ["0","0","0","1","1"]
]
Output: 3
*/

function DFS($i, $j, $grid) {
    if ($i < 0 || $i >= count($grid) || $j < 0 || $j >= count($grid[0]) || $grid[$i][$j] == '0') {
        return;
    }
    $grid[$i][$j] = '0';
    DFS($i + 1, $j, $grid);
    DFS($i - 1, $j, $grid);
    DFS($i, $j + 1, $grid);
    DFS($i, $j - 1, $grid);
}

function solve_number_of_islands($grid)
{
    if($grid[0] == null && count($grid[0]) == 0)
    {
        return 0;
    }
    $count = 0;
    for($i = 0; $i < count($grid); $i++)
    {
        for($j = 0; $j < count($grid[$i]); $j++)
        {
            if($grid[$i][$j] == '1')
            {
                $count++;
                DFS($i, $j, $grid);
            }
        }
    }
    return $count;
}

$grid = [
    ["1","1","1","1","0"],
    ["1","1","0","1","0"],
    ["1","1","0","0","0"],
    ["0","0","0","0","0"]
];

echo solve_number_of_islands($grid);
