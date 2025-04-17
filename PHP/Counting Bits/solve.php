<?php

/*Example 1:

Input: n = 2
Output: [0,1,1]
Explanation:
0 --> 0
1 --> 1
2 --> 10
Example 2:

Input: n = 5
Output: [0,1,1,2,1,2]
Explanation:
0 --> 0
1 --> 1
2 --> 10
3 --> 11
4 --> 100
5 --> 101*/

function solve_counting_bits($n) {
    $result = array_fill(0, $n + 1, 0);
    for ($i = 1; $i <= $n; $i++)
    {
        $result[$i] = $result[$i & ($i - 1)] + 1;
    }
    return $result;
}
