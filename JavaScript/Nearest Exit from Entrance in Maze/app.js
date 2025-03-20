/*Example 1:


Input: maze = [["+","+",".","+"],[".",".",".","+"],["+","+","+","."]], entrance = [1,2]
Output: 1
Explanation: There are 3 exits in this maze at [1,0], [0,2], and [2,3].
Initially, you are at the entrance cell [1,2].
- You can reach [1,0] by moving 2 steps left.
- You can reach [0,2] by moving 1 step up.
It is impossible to reach [2,3] from the entrance.
Thus, the nearest exit is [0,2], which is 1 step away.
Example 2:


Input: maze = [["+","+","+"],[".",".","."],["+","+","+"]], entrance = [1,0]
Output: 2
Explanation: There is 1 exit in this maze at [1,2].
[1,0] does not count as an exit since it is the entrance cell.
Initially, you are at the entrance cell [1,0].
- You can reach [1,2] by moving 2 steps right.
Thus, the nearest exit is [1,2], which is 2 steps away.
Example 3:


Input: maze = [[".","+"]], entrance = [0,0]
Output: -1
Explanation: There are no exits in this maze.

const maze = [["+", "+", ".", "+"], [".", ".", ".", "+"], ["+", "+", "+", "."]];
const entrance = [1, 2];*/

function BFS(maze, entrance, visited) {
    queue = []
    queue.push([entrance[0], entrance[1], 0])
    const key = (x, y) => `${x},${y}`;
    visited.add(key(entrance[0], entrance[1]));
    while (queue.length > 0) {
        const [x, y, dist] = queue.shift()
        if ((x === 0 || x === maze.length - 1 || y === 0 || y === maze[0].length - 1) && (x !== entrance[0] || y !== entrance[1])) {
            return dist
        }
        for (const [dx, dy] of [[-1, 0], [1, 0], [0, -1], [0, 1]]) {
            const nx = x + dx
            const ny = y + dy
            if (0 <= nx && nx < maze.length && 0 <= ny && ny < maze[0].length && maze[nx][ny] === "." && !visited.has(key(nx, ny))) {
                visited.add(key(nx, ny))
                queue.push([nx, ny, dist + 1])
            }
        }
    }
    return -1
}
function solve_nearest_exit(maze, entrance) {
    const visited = new Set()
    return BFS(maze, entrance, visited)
}

console.log(solve_nearest_exit(maze, entrance))
