<?php

$text1 = "abcde";
$text2 = "ace";

/*Example 1:

Input: text1 = "abcde", text2 = "ace" 
Output: 3  
Explanation: The longest common subsequence is "ace" and its length is 3.
Example 2:

Input: text1 = "abc", text2 = "abc"
Output: 3
Explanation: The longest common subsequence is "abc" and its length is 3.
Example 3:

Input: text1 = "abc", text2 = "def"
Output: 0
Explanation: There is no such common subsequence, so the result is 0.*/

function solve_longest_common_subsequence($text1, $text2) {
    $m = strlen($text1);
    $n = strlen($text2);
    $dp = array_fill(0, $m + 1, array_fill(0, $n + 1, 0));
    for ($i = 1; $i <= $m; $i++)
    {
        for ($j = 1; $j <= $n; $j++)
        {
            if ($text1[$i - 1] === $text2[$j - 1])
            {
                $dp[$i][$j] = $dp[$i - 1][$j - 1] + 1;
            }
            else
            {
                $dp[$i][$j] = max($dp[$i - 1][$j], $dp[$i][$j - 1]);
            }
        }
    }
    return $dp[$m][$n];
}

var_dump(solve_longest_common_subsequence($text1, $text2));