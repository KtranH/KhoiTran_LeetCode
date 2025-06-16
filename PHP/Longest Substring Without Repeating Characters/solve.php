<?php

$s = "abcabcbb";

/*
Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
*/

function solve_longest_substring_without_repeating_characters($s)
{
    $n = strlen($s);
    $left = 0;
    $max_length = 0;
    $map = [];
    for ($right = 0; $right < $n; $right++) {
        $ch = $s[$right];
        if (isset($map[$ch]) && $map[$ch] >= $left) {
            $left = $map[$ch] + 1;
        }
        $map[$ch] = $right;
        $temp = $right - $left + 1;
        if ($temp > $max_length) {
            $max_length = $temp;
        }
    }
    return $max_length;
}

print_r(solve_longest_substring_without_repeating_characters($s));
