<?php

$roman = [
    'I' => 1,
    'V' => 5,
    'X' => 10,
    'L' => 50,
    'C' => 100,
    'D' => 500,
    'M' => 1000
];

$s = "MCMXCIV";

/*
Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.
Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 3:

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
*/

function solve_roman_to_integer($s) {
    $result = 0;
    $n = strlen($s);
    $i = 0;
    while ($i < $n) {
        if ($i < $n - 1) {
            if ($roman[$s[$i]] < $roman[$s[$i + 1]]) {
                $result += ($roman[$s[$i + 1]] - $roman[$s[$i]]);
                $i += 2;
            } else {
                $result += $roman[$s[$i]];
                $i += 1;
            }
        } else {
            $result += $roman[$s[$i]];
            $i += 1;
        }
    }
    return $result;
}

print(solve_roman_to_integer($s));
