<?php

/*Example 1:

Input: digits = "23"
Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
Example 2:

Input: digits = ""
Output: []
Example 3:

Input: digits = "2"
Output: ["a","b","c"]*/

$digits = "23";

function backtracking($index, $path, &$result, $digits, $lenDigits, $phone) {
    if ($index == $lenDigits) {
        $result[] = $path;
        return;
    }
    $current_digit = $digits[$index];
    for ($i = 0; $i < strlen($phone[$current_digit]); $i++) {
        $path .= $phone[$current_digit][$i];
        backtracking($index + 1, $path, $result, $digits, $lenDigits, $phone);
        $path = substr($path, 0, -1);
    }
}

function solve_letter_combinations($digits) {
    if (empty($digits)) return [];
    $result = [];
    $lenDigits = strlen($digits);
    $phone = [
        "2" => "abc",
        "3" => "def",
        "4" => "ghi",
        "5" => "jkl",
        "6" => "mno",
        "7" => "pqrs",
        "8" => "tuv",
        "9" => "wxyz"
    ];
    backtracking(0, "", $result, $digits, $lenDigits, $phone);
    return $result;
}

$result = solve_letter_combinations($digits);
print_r($result);