<?php

/*Example 1:


Input: matrix = [["1","0","1","0","0"],["1","0","1","1","1"],["1","1","1","1","1"],["1","0","0","1","0"]]
Output: 4
Example 2:


Input: matrix = [["0","1"],["1","0"]]
Output: 1
Example 3:

Input: matrix = [["0"]]
Output: 0*/

function solve_maximal_square($matrix)
{
    $n = count($matrix);
    $m = count($matrix[0]);
    $dp = array_fill(0, $n + 1, array_fill(0, $m + 1, 0));
    $max_result = 0;
    for ($i = 1; $i <= $n; $i++)
    {
        for ($j = 1; $j <= $m; $j++)
        {
            if ($matrix[$i - 1][$j - 1] === "1")
            {
                $dp[$i][$j] = min($dp[$i - 1][$j], min($dp[$i - 1][$j - 1], $dp[$i][$j - 1])) + 1;
                $max_result = max($max_result, $dp[$i][$j]);
            }
        }
    }
    return $max_result * $max_result;
}

$matrix = [
    ["1", "0", "1", "0", "0"],
    ["1", "0", "1", "1", "1"],
    ["1", "1", "1", "1", "1"],
    ["1", "0", "0", "1", "0"]
];

var_dump(solve_maximal_square($matrix));
