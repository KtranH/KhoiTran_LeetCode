<?php

$s = "A man, a plan, a canal: Panama";

/*
Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.
*/

function solve_valid_palindrome($s) {
    $s = strtolower($s);
    $i = 0;
    $j = strlen($s) - 1;
    while ($i < $j) {
        if (!ctype_alnum($s[$i])) {
            $i++;
        } else if (!ctype_alnum($s[$j])) {
            $j--;
        } else {
            if ($s[$i] !== $s[$j]) {
                return false;
            }
            $i++;
            $j--;
        }
    }
    return true;
}

var_dump(solve_valid_palindrome($s));