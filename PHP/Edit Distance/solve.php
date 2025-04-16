<?php

$word1 = "horse";
$word2 = "ros";

/*Example 1:

Input: word1 = "horse", word2 = "ros"
Output: 3
Explanation: 
horse -> rorse (replace 'h' with 'r')
rorse -> rose (remove 'r')
rose -> ros (remove 'e')
Example 2:

Input: word1 = "intention", word2 = "execution"
Output: 5
Explanation: 
intention -> inention (remove 't')
inention -> enention (replace 'i' with 'e')
enention -> exention (replace 'n' with 'x')
exention -> exection (replace 'n' with 'c')
exection -> execution (insert 'u')*/

function solve_edit_distance($word1, $word2) {
    $m = strlen($word1);
    $n = strlen($word2);
    $dp = array_fill(0, $m + 1, array_fill(0, $n + 1, 0));
    for($i = 0; $i <= $m; $i++)
    {
        $dp[$i][0] = $i;
    }
    for($j = 0; $j <= $n; $j++)
    {
        $dp[0][$j] = $j;
    }
    for ($i = 1; $i <= $m; $i++)
    {
        for ($j = 1; $j <= $n; $j++)
        {
            if ($word1[$i - 1] === $word2[$j - 1])
            {
                $dp[$i][$j] = $dp[$i - 1][$j - 1];
            }
            else
            {
                $dp[$i][$j] = min($dp[$i - 1][$j], $dp[$i][$j - 1], $dp[$i - 1][$j - 1]) + 1;
            }
        }
    }
    return $dp[$m][$n];
}

var_dump(solve_edit_distance($word1, $word2));