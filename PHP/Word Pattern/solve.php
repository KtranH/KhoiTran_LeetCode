<?php

/*
Example 1:

Input: pattern = "abba", s = "dog cat cat dog"
Output: true
Example 2:

Input: pattern = "abba", s = "dog cat cat fish"
Output: false
Example 3:

Input: pattern = "aaaa", s = "dog cat cat dog"
Output: false
Example 4:

Input: pattern = "abba", s = "dog dog dog dog"
Output: false
*/

$pattern = "abba";
$s = "dog cat cat dog";

function solve_word_pattern($pattern, $s)
{
    $s = explode(" ", $s);
    if (strlen($pattern) != count($s)) {
        return false;
    }
    $pattern_map = array();
    for ($i = 0; $i < strlen($pattern); $i++) {
        if (!array_key_exists($pattern[$i], $pattern_map)) {
            if (in_array($s[$i], $pattern_map)) {
                return false;
            }
            $pattern_map[$pattern[$i]] = $s[$i];
        } else {
            if ($pattern_map[$pattern[$i]] != $s[$i]) {
                return false;
            }
        }
    }
    return true;
}