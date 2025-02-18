/*Example 1:


Input: grid = [[3,2,1],[1,7,6],[2,7,7]]
Output: 1
Explanation: There is 1 equal row and column pair:
- (Row 2, Column 1): [2,7,7]
Example 2:


Input: grid = [[3,1,2,2],[1,4,4,5],[2,4,2,2],[2,4,2,2]]
Output: 3
Explanation: There are 3 equal row and column pairs:
- (Row 0, Column 0): [3,1,2,2]
- (Row 2, Column 2): [2,4,2,2]
- (Row 3, Column 2): [2,4,2,2]*/

const grid = [[13,13],[13,13]];

function solve_equal_row_and_column_pairs(grid)
{
    let hashmap = new Map();
    let count = 0;
    let length_grid = grid.length;
    for (let i = 0; i < length_grid; i++)
    {
        let string = grid[i].join(',');
        if (hashmap.has(string)) hashmap.set(string, hashmap.get(string) + 1);
        else  hashmap.set(string, 1);
    }
    for(let i = 0; i < length_grid; i++)
    {
        let string = "";
        let arr = [];
        for(let j = 0; j < length_grid; j++)
        {
            arr[j] = grid[j][i];
        }
        string = arr.join(',');
        if (hashmap.has(string)) count += hashmap.get(string);
    }
    console.log(hashmap);
    return count;
}

console.log(solve_equal_row_and_column_pairs(grid));