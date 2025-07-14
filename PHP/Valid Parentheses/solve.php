<?php

$s = "()[]{}";

/*
Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
*/

function solve_valid_parentheses($s) {
    $stack = [];
    for ($i = 0; $i < strlen($s); $i++) {
        if ($s[$i] == '(' || $s[$i] == '[' || $s[$i] == '{') {
            array_push($stack, $s[$i]);
        } else {
            if (count($stack) == 0) return false;
            $top = array_pop($stack);
            if ($s[$i] == ')' && $top != '(') return false;
            if ($s[$i] == ']' && $top != '[') return false;
            if ($s[$i] == '}' && $top != '{') return false;
        }
    }
    return count($stack) == 0;
}

echo solve_valid_parentheses($s);