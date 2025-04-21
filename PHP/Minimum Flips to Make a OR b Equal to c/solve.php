<?php

$a = 2;
$b = 6;
$c = 5;

/*Example 1:



Input: a = 2, b = 6, c = 5
Output: 3
Explanation: After flips a = 1 , b = 4 , c = 5 such that (a OR b == c)
Example 2:

Input: a = 4, b = 2, c = 7
Output: 1
Example 3:

Input: a = 1, b = 2, c = 3
Output: 0*/

function solve_min_flips_to_make_a_or_b_equal_to_c($a, $b, $c) {
    $flip = 0;
    for ($i = 0; $i < 31; $i++) {
        $aBit = ($a >> $i) & 1;
        $bBit = ($b >> $i) & 1;
        $cBit = ($c >> $i) & 1;

        $orResult = $aBit | $bBit;
        if ($orResult == $cBit) {
            continue;
        }

        if ($cBit == 1) {
            $flip += 1;
        } else {
            $flip += $aBit + $bBit;
        }
    }
    return $flip;
}

var_dump(solve_min_flips_to_make_a_or_b_equal_to_c($a, $b, $c));

?>
