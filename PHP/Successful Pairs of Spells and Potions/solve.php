<?php

$spells = [5,1,3];
$potions = [1,2,3,4,5];
$success = 7;

/*Example 1:

Input: spells = [5,1,3], potions = [1,2,3,4,5], success = 7
Output: [4,0,3]
Explanation:
- 0th spell: 5 * [1,2,3,4,5] = [5,10,15,20,25]. 4 pairs are successful.
- 1st spell: 1 * [1,2,3,4,5] = [1,2,3,4,5]. 0 pairs are successful.
- 2nd spell: 3 * [1,2,3,4,5] = [3,6,9,12,15]. 3 pairs are successful.
Thus, [4,0,3] is returned.
Example 2:

Input: spells = [3,1,2], potions = [8,5,8], success = 16
Output: [2,0,2]
Explanation:
- 0th spell: 3 * [8,5,8] = [24,15,24]. 2 pairs are successful.
- 1st spell: 1 * [8,5,8] = [8,5,8]. 0 pairs are successful. 
- 2nd spell: 2 * [8,5,8] = [16,10,16]. 2 pairs are successful. 
Thus, [2,0,2] is returned.*/

function solve_successful_pairs($spells, $potions, $success) {
    sort($potions);
    
    $m = count($potions);
    $cache = [];
    
    return array_map(function($spell) use ($potions, $success, &$cache, $m) {
        if (isset($cache[$spell])) {
            return $cache[$spell];
        }
        
        $minPotion = floor(($success - 1) / $spell) + 1;
        
        $left = 0;
        $right = $m - 1;
        $index = $m;
        
        while ($left <= $right) {
            $mid = (int)(($left + $right) / 2);
            
            if ($potions[$mid] >= $minPotion) {
                $index = $mid;
                $right = $mid - 1;
            } else {
                $left = $mid + 1;
            }
        }
        
        $result = $m - $index;
        $cache[$spell] = $result;
        return $result;
    }, $spells);
}


echo solve_successful_pairs($spells, $potions, $success);


