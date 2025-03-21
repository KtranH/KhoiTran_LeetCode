/*Example 1:


Input: grid = [[2,1,1],[1,1,0],[0,1,1]]
Output: 4
Example 2:

Input: grid = [[2,1,1],[0,1,1],[1,0,1]]
Output: -1
Explanation: The orange in the bottom left corner (row 2, column 0) is never rotten, because rotting only happens 4-directionally.
Example 3:

Input: grid = [[0,2]]
Output: 0
Explanation: Since there are already no fresh oranges at minute 0, the answer is just 0.*/

const grid = [[2, 1, 1], [1, 1, 0], [0, 1, 1]];

function BFS(grid)
{
    let queue = [];
    let count_fresh = 0;
    for(let i = 0; i < grid.length; i++)
    {
        for(let j = 0; j < grid[0].length; j++)
        {
            if(grid[i][j] == 2)
                queue.push([i, j, 0]);
            else if(grid[i][j] == 1)
                count_fresh++;
        }
    }
    if(count_fresh == 0)
        return 0;
    while(queue.length > 0)
    {
        let [x, y, time] = queue.shift();
        for (const [dx, dy] of [[-1, 0], [1, 0], [0, -1], [0, 1]])
        {
            let nx = x + dx;
            let ny = y + dy;
            if(nx >= 0 && nx < grid.length && ny >= 0 && ny < grid[0].length && grid[nx][ny] == 1)
            {
                grid[nx][ny] = 2;
                queue.push([nx, ny, time + 1]);
                count_fresh--;
            }
        }
        if(count_fresh == 0)
            return time + 1;
    }
    return -1;
}

function solve_rotting_oranges(grid)
{
    return BFS(grid);
}

console.log(solve_rotting_oranges(grid));
