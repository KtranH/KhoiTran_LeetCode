<?php

/*Example 1:

Input: cost = [10,15,20]
Output: 15
Explanation: You will start at index 1.
- Pay 15 and climb two steps to reach the top.
The total cost is 15.
Example 2:

Input: cost = [1,100,1,1,1,100,1,1,100,1]
Output: 6
Explanation: You will start at index 0.
- Pay 1 and climb two steps to reach index 2.
- Pay 1 and climb two steps to reach index 4.
- Pay 1 and climb two steps to reach index 6.
- Pay 1 and climb one step to reach index 7.
- Pay 1 and climb two steps to reach index 9.
- Pay 1 and climb one step to reach the top.
The total cost is 6.*/

$cost = [10,15,20];

function solve_min_cost_climbing_stairs($cost) {
    $n = count($cost);
    $dp = array_fill(0, $n + 1, 0);

    for ($i = 2; $i <= $n; $i++) {
        $one_step = $dp[$i - 1] + $cost[$i - 1];
        $two_step = $dp[$i - 2] + $cost[$i - 2];
        if($one_step < $two_step) {
            $dp[$i] = $one_step;
        } else {
            $dp[$i] = $two_step;
        }
    }
    return $dp[$n];
}


echo solve_min_cost_climbing_stairs($cost);
