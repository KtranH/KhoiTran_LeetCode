"""
Example 1:

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
Example 3:

Input: equations = [["a","b"]], values = [0.5], queries = [["a","b"],["b","a"],["a","c"],["x","y"]]
Output: [0.50000,2.00000,-1.00000,-1.00000]
"""

from collections import defaultdict

equations = [["a","b"],["b","c"],["bc","cd"]]
values = [1.5,2.5,5.0]
queries = [["a","c"],["c","b"],["bc","cd"],["cd","bc"]]
values_dict = {}
for i in range(len(equations)):
    values_dict[(equations[i][0], equations[i][1])] = values[i]
    values_dict[(equations[i][1], equations[i][0])] = 1 / values[i]

def DFS(graph, visited, node, target, product):
    if node not in graph or target not in graph:
        return -1
    if node == target:
        return product
    visited.add(node)
    for neighbor in graph[node]:
        if neighbor not in visited:
            result = DFS(graph, visited, neighbor, target, product * values_dict[(node, neighbor)])
            if result != -1:
                return result
    return -1

def solve_evaluate_division(equations, values, queries):
    graph = defaultdict(list)
    for u,v in equations:
        graph[u].append(v)
        graph[v].append(u)
    results = []
    for query in queries:
        visited = set()
        results.append(DFS(graph, visited, query[0], query[1], 1.0))
    return results

print(solve_evaluate_division(equations, values, queries))

    