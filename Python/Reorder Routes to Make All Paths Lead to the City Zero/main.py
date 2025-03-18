"""
Example 1:


Input: n = 6, connections = [[0,1],[1,3],[2,3],[4,0],[4,5]]
Output: 3
Explanation: Change the direction of edges show in red such that each node can reach the node 0 (capital).
Example 2:


Input: n = 5, connections = [[1,0],[1,2],[3,2],[3,4]]
Output: 2
Explanation: Change the direction of edges show in red such that each node can reach the node 0 (capital).
Example 3:

Input: n = 3, connections = [[1,0],[2,0]]
Output: 0
"""

n = 6
connections = [[1,0],[2,0]]

from collections import defaultdict

def DFS(graph, direct_edges, visited, i):
    count = 0
    for j in graph[i]:
        if not visited[j]:
            visited[j] = True
            if (i, j) in direct_edges:
                count += 1
            count += DFS(graph, direct_edges, visited, j)
    return count

def solve_reorder_routes(n, connections):
    visited = [False] * n
    direct_edges = set()
    graph = defaultdict(list)
    for u, v in connections:
        graph[u].append(v)
        graph[v].append(u)
        direct_edges.add((u, v))
    visited[0] = True
    print(direct_edges)
    return DFS(graph, direct_edges, visited, 0)
    
print(solve_reorder_routes(n, connections))

