<?php

/*
Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
*/

$nums = [2,2,1,1,1,2,2];

function solve_majority_element($nums)
{
    $count = 0;
    $cadidate = null;
    foreach ($nums as $num)
    {
        if ($count == 0)
        {
            $cadidate = $num;
        }
        $count += ($num == $cadidate ? 1 : -1);
    }
    return $cadidate;
}

print_r(solve_majority_element($nums));
