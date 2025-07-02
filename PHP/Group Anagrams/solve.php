<?php

/*
Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
Example 2:

Input: strs = [""]
Output: [[""]]
*/

$strs = ["eat","tea","tan","ate","nat","bat"];

function solve_group_anagrams($strs) {
    $strs_map = [];
    foreach ($strs as $s) {
        $c_sort = str_split($s);
        sort($c_sort);
        $c_sort = implode($c_sort);
        if (array_key_exists($c_sort, $strs_map)) {
            $strs_map[$c_sort][] = $s;
        } else {
            $strs_map[$c_sort] = [$s];
        }
    }
    return array_values($strs_map);
}   

print_r(solve_group_anagrams($strs));