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
Output: [0.50000,2.00000,-1.00000,-1.00000]*/

equations = [["a","b"],["b","c"],["bc","cd"]]
values = [1.5,2.5,5.0]
queries = [["a","c"],["c","b"],["bc","cd"],["cd","bc"]]

function DFS(graph, values_dict, node, target, product, visited) {
    if (node == target) {
        return product;
    }
    visited.add(node)
    for (const neighbor of graph[node]) {
        if (!visited.has(neighbor)) {
            const result = DFS(graph, values_dict, neighbor, target, product * values_dict[`${node},${neighbor}`], visited);
            if (result != -1.0) {
                return result;
            }
        }
    } 
    return -1.0;
}
function solve_evaluate_division(equations, values, queries) {
    graph = {}
    values_dict = {}
    for (let i = 0; i < equations.length; i++) {
        const [u, v] = equations[i];
        const value = values[i];
        if(!graph[u]) {
            graph[u] = [];
        }
        if(!graph[v]) {
            graph[v] = [];
        }
        graph[u].push(v);
        graph[v].push(u);
        values_dict[`${u},${v}`] = value;
        values_dict[`${v},${u}`] = 1 / value;
    }
    results = []
    for (const [u, v] of queries) {
        if (u in graph && v in graph) {
            results.push(DFS(graph, values_dict, u, v, 1.0, new Set()));
        } else {
            results.push(-1.0);
        }
    }
    return results;
}

console.log(solve_evaluate_division(equations, values, queries));
