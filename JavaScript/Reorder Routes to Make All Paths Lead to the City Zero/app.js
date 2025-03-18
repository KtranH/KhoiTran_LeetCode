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

function dfs(node, visited, graph, directEdges) {
    let count = 0
    for (let neighbor of graph[node]) {
        if (!visited[neighbor]) {
            visited[neighbor] = true
            if (directEdges.has(`${node},${neighbor}`)) {
                count++
            }
            count += dfs(neighbor, visited, graph, directEdges)
        }
    }
    return count
}   
function solve_reorder_routes() {
    const connections = [[0,1],[1,3],[2,3],[4,0],[4,5]]
    const n = 6
    const visited = new Array(n).fill(false)
    const directEdges = new Set(connections.map(conn => `${conn[0]},${conn[1]}`))
    const graph = connections.reduce((acc, conn) => {
        const [u, v] = conn
        acc[u] = acc[u] || []
        acc[v] = acc[v] || []
        acc[u].push(v)
        acc[v].push(u)
        return acc
    }, {})
    visited[0] = true
    return dfs(0, visited, graph, directEdges)
}

console.log(solve_reorder_routes())
