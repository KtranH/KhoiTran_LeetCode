const matrix = [[1,1,1],[1,0,1],[1,1,1]];

/*
Example 1:

Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
Output: [[1,0,1],[0,0,0],[1,0,1]]
Example 2:

Input: matrix = [[0,1,2,0],[3,4,5,2],[1,3,1,5]]
Output: [[0,0,0,0],[0,4,5,0],[0,3,1,0]]
*/

function solve_set_matrix_zeroes(matrix) {
    let n = matrix.length;
    let m = matrix[0].length;

    let first_row_zero = false;
    let first_col_zero = false;

    for (let j = 0; j < m; j++) {
        if (matrix[0][j] == 0) {
            first_row_zero = true;
            break;
        }
    }

    for (let i = 0; i < n; i++) {
        if (matrix[i][0] == 0) {
            first_col_zero = true;
            break;
        }
    }

    for (let i = 1; i < n; i++) {
        for (let j = 1; j < m; j++) {
            if (matrix[i][j] == 0) {
                matrix[i][0] = 0;
                matrix[0][j] = 0;
            }
        }
    }

    for (let i = 1; i < n; i++) {
        for (let j = 1; j < m; j++) {
            if (matrix[i][0] == 0 || matrix[0][j] == 0) {
                matrix[i][j] = 0;
            }
        }
    }

    if (first_row_zero) {
        for (let j = 0; j < m; j++) {
            matrix[0][j] = 0;
        }
    }

    if (first_col_zero) {
        for (let i = 0; i < n; i++) {
            matrix[i][0] = 0;
        }
    }

    return matrix;
}

console.log(solve_set_matrix_zeroes(matrix));