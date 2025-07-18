<?php

/*
Example 1:

Input: tokens = ["2","1","+","3","*"]
Output: 9
Explanation: ((2 + 1) * 3) = 9
Example 2:

Input: tokens = ["4","13","5","/","+"]
Output: 6
Explanation: (4 + (13 / 5)) = 6
Example 3:

Input: tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]
Output: 22
*/

$tokens = ["2","1","+","3","*"];

function solve_ReversePolishNotation($tokens) {
    $stack = [];
    foreach ($tokens as $token) {
        if ($token == "+") {
            $stack[] = array_pop($stack) + array_pop($stack);
        } elseif ($token == "-") {
            $b = array_pop($stack);
            $a = array_pop($stack);
            $stack[] = $a - $b;
        } elseif ($token == "*") {
            $stack[] = array_pop($stack) * array_pop($stack);
        } elseif ($token == "/") {
            $b = array_pop($stack);
            $a = array_pop($stack);
            $stack[] = intdiv($a, $b);
        } else {
            $stack[] = $token;
        }
    }
    return $stack[0];
}

print(solve_ReversePolishNotation($tokens));
