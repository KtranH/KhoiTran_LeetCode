<?php

$s = "babad";

/*Example 1:

Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.
Example 2:

Input: s = "cbbd"
Output: "bb"
*/

function expand_from_center($left, $right, $s)
{
    while ($left >= 0 && $right < strlen($s) && $s[$left] === $s[$right])
    {
        $left--;
        $right++;
    }
    return substr($s, $left + 1, $right - $left - 1);
}

function solve_longest_palindromic_substring($s)
{
    $result = "";
    for ($i = 0; $i < strlen($s); $i++)
    {
        $s1 = expand_from_center($i, $i, $s);
        $s2 = expand_from_center($i, $i + 1, $s);
        $result = strlen($result) > strlen($s1) ? $result : $s1;
        $result = strlen($result) > strlen($s2) ? $result : $s2;
    }
    return $result;
}

var_dump(solve_longest_palindromic_substring($s));
