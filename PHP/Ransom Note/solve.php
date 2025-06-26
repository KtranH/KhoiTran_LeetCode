<?php

$ransomNote = "a", $magazine = "b";

/*
Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
*/

function solve_ransom_note($ransomNote, $magazine) {
    $magazine_map = [];
    for ($i = 0; $i < strlen($magazine); $i++) {
        if (isset($magazine_map[$magazine[$i]])) {
            $magazine_map[$magazine[$i]]++;
        } else {
            $magazine_map[$magazine[$i]] = 1;
        }
    }
    for ($i = 0; $i < strlen($ransomNote); $i++) {
        if (isset($magazine_map[$ransomNote[$i]])) {
            $magazine_map[$ransomNote[$i]]--;
        }
        if ($magazine_map[$ransomNote[$i]] < 0 || !isset($magazine_map[$ransomNote[$i]])) {
            return false;
        }
    }
    return true;
}

var_dump(solve_ransom_note($ransomNote, $magazine));