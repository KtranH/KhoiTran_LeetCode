
/*
Example 1:

Input: grid = [
  ["1","1","1","1","0"],
  ["1","1","0","1","0"],
  ["1","1","0","0","0"],
  ["0","0","0","0","0"]
]
Output: 1
Example 2:

Input: grid = [
  ["1","1","0","0","0"],
  ["1","1","0","0","0"],
  ["0","0","1","0","0"],
  ["0","0","0","1","1"]
]
Output: 3
*/

function DFS(i, j, grid) {
    if (i < 0 || i >= grid.length || j < 0 || j >= grid[0].length || grid[i][j] == '0') {
        return;
    }
    grid[i][j] = '0';
    DFS(i + 1, j, grid);
    DFS(i - 1, j, grid);
    DFS(i, j + 1, grid);
    DFS(i, j - 1, grid);
}

function solve_number_of_islands(grid) {
    if(grid[0] == null && grid[0].length == 0)
        return 0;
    let count = 0;
    for(let i = 0; i < grid.length; i++)
    {
        for(let j = 0; j < grid[i].length; j++)
        {
            if(grid[i][j] == '1')
            {
                count++;
                DFS(i, j, grid);
            }
        }
    }
    return count;
}

const grid = [
    ["1","1","1","1","0"],
    ["1","1","0","1","0"],
    ["1","1","0","0","0"],
    ["0","0","0","0","0"]
];
console.log(solve_number_of_islands(grid));
