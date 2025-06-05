<?php

/*
Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
*/

$strs = ["flower","flow","flight"];

function solve_longest_common_prefix($strs) {
    if (count($strs) === 0) return "";
    $prefix = $strs[0];
    for ($i = 1; $i < count($strs); $i++) {
        while (strpos($strs[$i], $prefix) !== 0) {
            $prefix = substr($prefix, 0, -1);
            if (empty($prefix)) return "";
        }
    }
    return $prefix;
}

print_r(solve_longest_common_prefix($strs));
