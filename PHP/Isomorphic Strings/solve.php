<?php

$s = "egg";
$t = "add";

/*
Example 1:

Input: s = "egg", t = "add"
Output: true
Example 2:

Input: s = "foo", t = "bar"
Output: false
Example 3:

Input: s = "paper", t = "title"
Output: true
*/

function solve_isomorphic($s, $t) {
    $map_s_t = array();
    $map_t_s = array();
    
    for ($i = 0; $i < strlen($s); $i++) {
        if (array_key_exists($s[$i], $map_s_t)) {
            if ($map_s_t[$s[$i]] != $t[$i]) {
                return false;
            }
        } else {
            $map_s_t[$s[$i]] = $t[$i];
        }
        if (array_key_exists($t[$i], $map_t_s)) {
            if ($map_t_s[$t[$i]] != $s[$i]) {
                return false;
            }
        } else {
            $map_t_s[$t[$i]] = $s[$i];
        }
    }
    return true;
}

var_dump(solve_isomorphic($s, $t));