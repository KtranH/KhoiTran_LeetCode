const board = [[0,1,0],[0,0,1],[1,1,1],[0,0,0]]

/*
Example 1:

Input: board = [[0,1,0],[0,0,1],[1,1,1],[0,0,0]]
Output: [[0,0,0],[0,0,0],[1,1,1],[0,0,0]]
Example 2:

Input: board = [[1,1,0],[1,0,1],[0,1,1]]
Output: [[1,1,0],[1,0,1],[0,1,1]]
*/

function solve_game_of_life(board) {
    let n = board.length;
    let m = board[0].length;
    let board_copy = board.map(row => row.slice());
    let direction = [
        [-1, -1], [-1, 0], [-1, 1],
        [0, -1],           [0, 1],
        [1, -1],  [1, 0],  [1, 1]
    ];
    for (let i = 0; i < n; i++) {
        for (let j = 0; j < m; j++) {
            let live = 0;
            for (let [dx, dy] of direction) {
                let x = i + dx;
                let y = j + dy;
                if (x >= 0 && x < n && y >= 0 && y < m && board_copy[x][y] == 1)
                    live++;
            }
            if (board_copy[i][j] == 1 && (live < 2 || live > 3))
                board[i][j] = 0;
            else if (board_copy[i][j] == 0 && live == 3)
                board[i][j] = 1;
        }
    }
    return board;
}

console.log(solve_game_of_life(board));
