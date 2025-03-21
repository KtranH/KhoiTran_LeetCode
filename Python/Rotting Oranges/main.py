"""
Example 1:


Input: grid = [[2,1,1],[1,1,0],[0,1,1]]
Output: 4
Example 2:

Input: grid = [[2,1,1],[0,1,1],[1,0,1]]
Output: -1
Explanation: The orange in the bottom left corner (row 2, column 0) is never rotten, because rotting only happens 4-directionally.
Example 3:

Input: grid = [[0,2]]
Output: 0
Explanation: Since there are already no fresh oranges at minute 0, the answer is just 0.
"""

from collections import deque

grid = [[2,1,1],[1,1,0],[0,1,1]]

def BFS(grid):
    count_fresh = 0
    queue = deque()
    for i in range(len(grid)):
        for j in range(len(grid[0])):
            if grid[i][j] == 2:
                queue.append((i, j, 0))
            elif grid[i][j] == 1:
                count_fresh += 1
    if(count_fresh == 0):
        return 0
    while queue:
        x, y, time = queue.popleft()
        for dx, dy in [(-1, 0), (1, 0), (0, -1), (0, 1)]:
            nx, ny = x + dx, y + dy
            if 0 <= nx < len(grid) and 0 <= ny < len(grid[0]) and grid[nx][ny] == 1:
                grid[nx][ny] = 2
                queue.append((nx, ny, time + 1))
                count_fresh -= 1
    if(count_fresh == 0):
        return time
    return -1
    
def solve_rotting_oranges(grid):
    return BFS(grid)
    
print(solve_rotting_oranges(grid))
