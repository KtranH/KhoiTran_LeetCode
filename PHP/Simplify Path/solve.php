<?php

$path = "/home//foo/";

/*
Example 1:

Input: path = "/home//foo/"
Output: "/home/foo"
Explanation: In the canonical path, multiple slashes are replaced by a single one.
Example 2:

Input: path = "/a/./b/../../c/"
Output: "/c"
*/

function solve_simplify_path($path) {
    $stack = [];
    $tokens = explode('/', $path);
    foreach ($tokens as $token) {
        if ($token === '' || $token === '.') {
            continue;
        } elseif ($token === '..') {
            if (!empty($stack)) {
                array_pop($stack);
            }
        } else {
            $stack[] = $token;
        }
    }
    return '/' . implode('/', $stack);
}

print_r(solve_simplify_path($path));