<?php

/*
Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
First occurrence is at index 0, so we return 0.
Example 2:

Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
*/

$haystack = "sadbutsad";
$needle = "sad";

function solve_find_index_of_first_occurrence_in_a_string($haystack, $needle) {
    if (strpos($haystack, $needle) !== false) {
        return strpos($haystack, $needle);
    }
    return -1;
}

var_dump(solve_find_index_of_first_occurrence_in_a_string($haystack, $needle));