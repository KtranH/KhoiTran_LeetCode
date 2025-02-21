<?php

$s = "3[a]2[bc]";

function solve_decode_string($s) {
    $stack = [];
    $current_num = 0;
    $current_char = '';

    for ($i = 0; $i < strlen($s); $i++) {
        if(is_numeric($s[$i])) {
            $current_num = $current_num * 10 + (int)$s[$i];
        } else if($s[$i] === '[') {
            $stack[] = [$current_num, $current_char];
            $current_num = 0;
            $current_char = '';
        } else if($s[$i] === ']') {
            [$prev_num, $prev_char] = array_pop($stack);
            $current_char = $prev_char. str_repeat($current_char, $prev_num);
        } else {
            $current_char .= $s[$i];
        }
    }
    return $current_char;
}

echo solve_decode_string($s);