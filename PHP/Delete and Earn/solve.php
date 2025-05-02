<?php

$nums = [3,4,2];

/*Example 1:

Input: nums = [3,4,2]
Output: 6
Explanation: You can perform the following operations:
- Delete 4 to earn 4 points. Consequently, 3 is also deleted. nums = [2].
- Delete 2 to earn 2 points. nums = [].
You earn a total of 6 points.
Example 2:

Input: nums = [2,2,3,3,3,4]
Output: 9
Explanation: You can perform the following operations:
- Delete a 3 to earn 3 points. All 2's and 4's are also deleted. nums = [3,3].
- Delete a 3 again to earn 3 points. nums = [3].
- Delete a 3 once more to earn 3 points. nums = [].
You earn a total of 9 points.*/

function solve_delete_and_earn($nums) {
    if (count($nums) === 0) return 0;
    $maxNum = max($nums);
    $points = array_fill(0, $maxNum + 1, 0);
    foreach ($nums as $num) {
        $points[$num] += $num;
    }
    $prev = 0;
    $curr = 0;
    for ($i = 0; $i < count($points); $i++) {
        $temp = $curr;
        $curr = max($curr, $prev + $points[$i]);
        $prev = $temp;
    }
    return $curr;
}

var_dump(solve_delete_and_earn($nums));