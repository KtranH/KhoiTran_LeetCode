<?php

/*Example 1:


Input: n = 6, connections = [[0,1],[1,3],[2,3],[4,0],[4,5]]
Output: 3
Explanation: Change the direction of edges show in red such that each node can reach the node 0 (capital).
Example 2:


Input: n = 5, connections = [[1,0],[1,2],[3,2],[3,4]]
Output: 2
Explanation: Change the direction of edges show in red such that each node can reach the node 0 (capital).
Example 3:

Input: n = 3, connections = [[1,0],[2,0]]
Output: 0*/

/*function DFS($node, $visited, $direct_edges, $graph)
{
    $count = 0;
    foreach ($graph[$node] as $neighbor) {
        if (!$visited[$neighbor]) {
            $visited[$neighbor] = true;
            if (isset($direct_edges["$node,$neighbor"])) {
                $count++;
            }
            $count += DFS($neighbor, $visited, $direct_edges, $graph);
        }
    }
    return $count;
}

function solve_reorder_routes()
{
    $connections = [[0,1],[1,3],[2,3],[4,0],[4,5]];
    $n = 6;
    $visited = array_fill(0, $n, false);
    $direct_edges = [];
    foreach ($connections as $conn) {
        $direct_edges["{$conn[0]},{$conn[1]}"] = true;
    }
    $graph = [];
    foreach($connections as $conn)
    {
        $graph[$conn[0]][] = $conn[1];
        $graph[$conn[1]][] = $conn[0];
    }
    $visited[0] = true;
    return DFS(0, $visited, $direct_edges, $graph);
}*/


function DFS_iterative($n, &$graph, &$direct_edges) {
    $count = 0;
    $stack = [0]; // Bắt đầu từ node 0
    $visited = array_fill(0, $n, false);
    $visited[0] = true;

    while (!empty($stack)) {
        $node = array_pop($stack);
        foreach ($graph[$node] as $neighbor) {
            if (!$visited[$neighbor]) {
                $visited[$neighbor] = true;
                if (isset($direct_edges["$node,$neighbor"])) {
                    $count++;
                }
                $stack[] = $neighbor;
            }
        }
    }

    return $count;
}

function solve_reorder_routes($n, $connections) {
    $direct_edges = [];
    foreach ($connections as $conn) {
        $direct_edges["{$conn[0]},{$conn[1]}"] = true;
    }

    $graph = array_fill(0, $n, []);
    foreach ($connections as $conn) {
        list($u, $v) = $conn;
        $graph[$u][] = $v;
        $graph[$v][] = $u;
    }

    return DFS_iterative($n, $graph, $direct_edges);
}

echo solve_reorder_routes(6, [[0,1],[1,3],[2,3],[4,0],[4,5]]);


