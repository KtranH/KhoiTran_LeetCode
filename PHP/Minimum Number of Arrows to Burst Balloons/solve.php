<?php

$points = [[10,16],[2,8],[1,6],[7,12]];

/*Example 1:

Input: points = [[10,16],[2,8],[1,6],[7,12]]
Output: 2
Explanation: The balloons can be burst by 2 arrows:
- Shoot an arrow at x = 6, bursting the balloons [2,8] and [1,6].
- Shoot an arrow at x = 11, bursting the balloons [10,16] and [7,12].
Example 2:

Input: points = [[1,2],[3,4],[5,6],[7,8]]
Output: 4
Explanation: One arrow needs to be shot for each balloon for a total of 4 arrows.
Example 3:

Input: points = [[1,2],[2,3],[3,4],[4,5]]
Output: 2
Explanation: The balloons can be burst by 2 arrows:
- Shoot an arrow at x = 2, bursting the balloons [1,2] and [2,3].
- Shoot an arrow at x = 4, bursting the balloons [3,4] and [4,5].*/

function solve_min_number_of_arrows_to_burst_balloons($points) {
    usort($points, function($a, $b) {
        return $a[1] - $b[1];
    });
    $last_end = $points[0][1];
    $arrows = 1;
    foreach ($points as $point) {
        if ($point[0] > $last_end) {
            $arrows++;
            $last_end = $point[1];
        }
    }
    return $arrows;
}
