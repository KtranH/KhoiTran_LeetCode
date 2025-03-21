<?php


/*Example 1:


Input: grid = [[2,1,1],[1,1,0],[0,1,1]]
Output: 4
Example 2:

Input: grid = [[2,1,1],[0,1,1],[1,0,1]]
Output: -1
Explanation: The orange in the bottom left corner (row 2, column 0) is never rotten, because rotting only happens 4-directionally.
Example 3:

Input: grid = [[0,2]]
Output: 0
Explanation: Since there are already no fresh oranges at minute 0, the answer is just 0.*/

$grid = [[2, 1, 1], [1, 1, 0], [0, 1, 1]];

function BFS($grid)
{
    $queue = [];
    $count_fresh = 0;
    for($i = 0; $i < count($grid); $i++)
    {
        for($j = 0; $j < count($grid[0]); $j++)
        {
            if($grid[$i][$j] == 2)
                array_push($queue, [$i, $j, 0]);
            else if($grid[$i][$j] == 1)
                $count_fresh++;
        }
    }
    if($count_fresh == 0)
        return 0;
    while(count($queue) > 0)
    {
        $current = array_shift($queue);
        $x = $current[0];
        $y = $current[1];
        $time = $current[2];
        $directions = [[-1, 0], [1, 0], [0, -1], [0, 1]];
        foreach($directions as $direction)
        {
            $newX = $x + $direction[0];
            $newY = $y + $direction[1];
            if($newX >= 0 && $newX < count($grid) && $newY >= 0 && $newY < count($grid[0]) && $grid[$newX][$newY] == 1)
            {
                $grid[$newX][$newY] = 2;
                array_push($queue, [$newX, $newY, $time + 1]);
                $count_fresh--;
            }
        }
        if($count_fresh == 0)
            return $time + 1;
    }
    return -1;
}

function solve_rotting_oranges($grid)
{
    return BFS($grid);
}

print_r(solve_rotting_oranges($grid));

