<?php

/*Example 1:

Input: nums = [1,2,3,1]
Output: 4
Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
Total amount you can rob = 1 + 3 = 4.
Example 2:

Input: nums = [2,7,9,3,1]
Output: 12
Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
Total amount you can rob = 2 + 9 + 1 = 12.*/

$nums = [1,2,3,1];
function solve_house_robber($nums) {
    $prev2 = 0;
    $prev1 = 0;
    for ($i = 0; $i < count($nums); $i++)
    {
        $curr = max($prev1, $prev2 + $nums[$i]);
        $prev2 = $prev1;
        $prev1 = $curr;
    }
    return $prev1;
}

echo solve_house_robber($nums);