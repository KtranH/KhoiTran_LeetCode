<?php

/*
Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false
*/

$s = "anagram";
$t = "nagaram";

function solve_valid_anagram($s, $t) {
    $s_map = [];
    for ($i = 0; $i < strlen($s); $i++) {
        if (isset($s_map[$s[$i]])) {
            $s_map[$s[$i]]++;
        } else {
            $s_map[$s[$i]] = 1;
        }
    }
    $t_map = [];
    for ($i = 0; $i < strlen($t); $i++) {
        if (isset($t_map[$t[$i]])) {
            $t_map[$t[$i]]++;
        } else {
            $t_map[$t[$i]] = 1;
        }
    }
    if (count($s_map) != count($t_map)) {
        return false;
    }
    foreach ($s_map as $key => $value) {
        if ($value != $t_map[$key] || !isset($t_map[$key])) {
            return false;
        }
    }
    return true;
}

var_dump(solve_valid_anagram($s, $t));