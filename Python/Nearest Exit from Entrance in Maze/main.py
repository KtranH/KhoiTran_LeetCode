"""
Example 1:


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
"""

from collections import deque

maze = [["+","+",".","+"],[".",".",".","+"],["+","+","+","."]]
entrance = [1,2]

def BFS(maze, entrance, visited):
    queue = deque([(entrance[0], entrance[1], 0)])
    visited.add((entrance[0], entrance[1]))
    while queue:
        x, y, dist = queue.popleft()    
        if (x == 0 or x == len(maze) - 1 or y == 0 or y == len(maze[0]) - 1) and (x,y) != (entrance[0], entrance[1]):
            return dist
        for dx, dy in [(-1, 0), (1, 0), (0, -1), (0, 1)]:
            nx, ny = x + dx, y + dy
            if 0 <= nx < len(maze) and 0 <= ny < len(maze[0]) and (nx, ny) not in visited and maze[nx][ny] == ".":
                visited.add((nx, ny))
                queue.append((nx, ny, dist + 1))
    return -1
def solve_nearest_exit(maze, entrance):
    visited = set()
    result = BFS(maze, entrance, visited)
    return result

print(solve_nearest_exit(maze, entrance))
