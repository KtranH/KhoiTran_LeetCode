<?php

/*Example 1:

Input: costs = [17,12,10,2,7,2,11,20,8], k = 3, candidates = 4
Output: 11
Explanation: We hire 3 workers in total. The total cost is initially 0.
- In the first hiring round we choose the worker from [17,12,10,2,7,2,11,20,8]. The lowest cost is 2, and we break the tie by the smallest index, which is 3. The total cost = 0 + 2 = 2.
- In the second hiring round we choose the worker from [17,12,10,7,2,11,20,8]. The lowest cost is 2 (index 4). The total cost = 2 + 2 = 4.
- In the third hiring round we choose the worker from [17,12,10,7,11,20,8]. The lowest cost is 7 (index 3). The total cost = 4 + 7 = 11. Notice that the worker with index 3 was common in the first and last four workers.
The total hiring cost is 11.
Example 2:

Input: costs = [1,2,4,1], k = 3, candidates = 3
Output: 4
Explanation: We hire 3 workers in total. The total cost is initially 0.
- In the first hiring round we choose the worker from [1,2,4,1]. The lowest cost is 1, and we break the tie by the smallest index, which is 0. The total cost = 0 + 1 = 1. Notice that workers with index 1 and 2 are common in the first and last 3 workers.
- In the second hiring round we choose the worker from [2,4,1]. The lowest cost is 1 (index 2). The total cost = 1 + 1 = 2.
- In the third hiring round there are less than three candidates. We choose the worker from the remaining workers [2,4]. The lowest cost is 2 (index 0). The total cost = 2 + 2 = 4.
The total hiring cost is 4.*/

$costs = [25,20,60,21,11,99,55,22,83,62,12,63,100,41,33,92,13,92,58,85,61,93,5,46,26,25,36,27,12,30,13,52,30];
$k = 8;
$candidates = 22;

function solve_total_cost_to_hire_k_workers($costs, $k, $candidates) {
    $min_left_heap = new SplMinHeap();
    $min_right_heap = new SplMinHeap();
    $left = 0;
    $right = count($costs) - 1;
    for ($i = 0; $i < $candidates && $left <= $right; $i++) {
        $min_left_heap->insert($costs[$left]);
        $left++;
    }
    for ($i = 0; $i < $candidates && $left <= $right; $i++) {
        $min_right_heap->insert($costs[$right]);
        $right--;
    }
    $total_cost = 0;
    for ($i = 0; $i < $k; $i++) {
        if ($min_right_heap->isEmpty() || (!$min_left_heap->isEmpty() && $min_left_heap->top() <= $min_right_heap->top())) {
            $total_cost += $min_left_heap->extract();
            if ($left <= $right) {
                $min_left_heap->insert($costs[$left]);
                $left++;
            }
        } else {
            $total_cost += $min_right_heap->extract();
            if ($left <= $right) {
                $min_right_heap->insert($costs[$right]);
                $right--;
            }
        }
    }
    return $total_cost;
}

echo solve_total_cost_to_hire_k_workers($costs, $k, $candidates);



