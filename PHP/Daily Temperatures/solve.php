<?php

/*Example 1:

Input: temperatures = [73,74,75,71,69,72,76,73]
Output: [1,1,4,2,1,1,0,0]
Example 2:

Input: temperatures = [30,40,50,60]
Output: [1,1,1,0]
Example 3:

Input: temperatures = [30,60,90]
Output: [1,1,0]*/

$temperatures = [73,74,75,71,69,72,76,73];

function solve_daily_temperatures($temperatures) {
    $n = count($temperatures);
    $result = array_fill(0, $n, 0);
    $stack = [];
    for ($i = 0; $i < $n; $i++)
    {
        while (count($stack) > 0 && $temperatures[$i] > $temperatures[$stack[count($stack) - 1]])
        {
            $prev = array_pop($stack);
            $result[$prev] = $i - $prev;
        }
        $stack[] = $i;
    }
    return $result;
}