<?php

/*Example 1:

Input: equations = [["a","b"],["b","c"]], values = [2.0,3.0], queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]]
Output: [6.00000,0.50000,-1.00000,1.00000,-1.00000]
Explanation: 
Given: a / b = 2.0, b / c = 3.0
queries are: a / c = ?, b / a = ?, a / e = ?, a / a = ?, x / x = ? 
return: [6.0, 0.5, -1.0, 1.0, -1.0 ]
note: x is undefined => -1.0
Example 2:

Input: equations = [["a","b"],["b","c"],["bc","cd"]], values = [1.5,2.5,5.0], queries = [["a","c"],["c","b"],["bc","cd"],["cd","bc"]]
Output: [3.75000,0.40000,5.00000,0.20000]

[1,0] does not count as an exit since it is the entrance cell.
Initially, you are at the entrance cell [1,0].
- You can reach [1,2] by moving 2 steps right.
Thus, the nearest exit is [1,2], which is 2 steps away.
Example 3:

Input: equations = [["a","b"]], values = [0.5], queries = [["a","b"],["b","a"],["a","c"],["x","y"]]
Output: [0.50000,2.00000,-1.00000,-1.00000]
*/

$equations = [["a","b"], ["b","c"]];
$values = [2.0, 3.0];
$queries = [["a","c"], ["b","a"], ["a","e"], ["a","a"], ["x","x"]];


function solve_evaluate_division($equations, $values, $queries) {
    $graph = [];
    $values_dict = [];
    $visited = [];
    for ($i = 0; $i < count($equations); $i++) {
        $u = $equations[$i][0];
        $v = $equations[$i][1];
        $value = $values[$i];
        if (!isset($graph[$u])) {
            $graph[$u] = [];
        }
        if (!isset($graph[$v])) {
            $graph[$v] = [];
        }
        $graph[$u][] = $v;
        $graph[$v][] = $u;
        $values_dict[$u . "," . $v] = $value;
        $values_dict[$v . "," . $u] = 1 / $value;
        $visited[$u] = false;
        $visited[$v] = false;
    }
    $results = [];
    foreach ($queries as $query) {
        $u = $query[0];
        $v = $query[1];
        if (isset($graph[$u]) && isset($graph[$v])) {
            $results[] = DFS($graph, $values_dict, $u, $v, 1.0, $visited);
        } else {
            $results[] = -1.0;
        }
    }
    return $results;
}

function DFS($graph, $values_dict, $node, $target, $product, $visited) {
    if ($node == $target) {
        return $product;
    }
    $visited[$node] = true;
    foreach ($graph[$node] as $neighbor) {
        if (!$visited[$neighbor]) {
            $result = DFS($graph, $values_dict, $neighbor, $target, $product * $values_dict[$node . "," . $neighbor], $visited);
            if ($result != -1.0) {
                return $result;
            }
        }
    }
    $visited[$node] = false;
    return -1.0;
}

echo solve_evaluate_division($equations, $values, $queries);