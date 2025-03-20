<?php

/*Example 1:


Input: maze = [["+","+",".","+"],[".",".",".","+"],["+","+","+","."]], entrance = [1,2]
Output: 1
Explanation: There are 3 exits in this maze at [1,0], [0,2], and [2,3].
Initially, you are at the entrance cell [1,2].
- You can reach [1,0] by moving 2 steps left.
- You can reach [0,2] by moving 1 step up.
It is impossible to reach [2,3] from the entrance.
Thus, the nearest exit is [0,2], which is 1 step away.
Example 2:


Input: maze = [["+","+","+"],[".",".","."],["+","+","+"]], entrance = [1,0]
Output: 2
Explanation: There is 1 exit in this maze at [1,2].
[1,0] does not count as an exit since it is the entrance cell.
Initially, you are at the entrance cell [1,0].
- You can reach [1,2] by moving 2 steps right.
Thus, the nearest exit is [1,2], which is 2 steps away.
Example 3:


Input: maze = [[".","+"]], entrance = [0,0]
Output: -1
Explanation: There are no exits in this maze.*/
 

$maze = [["+","+",".","+"],[".",".",".","+"],["+","+","+","."],[".",".",".","."]];
$entrance = [1,2];

function BFS($maze, $entrance, $visited) {
    $queue = [];
    array_push($queue, [$entrance[0], $entrance[1], 0]);
    $key = function($x, $y) { return $x . "," . $y; };
    $visited[$key($entrance[0], $entrance[1])] = true;
    while (count($queue) > 0) {
        $current = array_shift($queue);
        $x = $current[0];
        $y = $current[1];
        $dist = $current[2];
        if (($x == 0 || $x == count($maze) - 1 || $y == 0 || $y == count($maze[0]) - 1) && ($x != $entrance[0] || $y != $entrance[1])) {
            return $dist;
        }
        $directions = [[-1, 0], [1, 0], [0, -1], [0, 1]];
        foreach ($directions as $direction) {
            $newX = $x + $direction[0];
            $newY = $y + $direction[1];
            if ($newX >= 0 && $newX < count($maze) && $newY >= 0 && $newY < count($maze[0]) && !isset($visited[$key($newX, $newY)]) && $maze[$newX][$newY] == ".") {
                $visited[$key($newX, $newY)] = true;
                array_push($queue, [$newX, $newY, $dist + 1]);
            }
        }
    }
    return -1;
}
function solve_nearest_exit($maze, $entrance) {
    $visited = [];
    return BFS($maze, $entrance, $visited);
}
