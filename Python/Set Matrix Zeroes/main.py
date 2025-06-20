matrix = [[1,1,0],[1,1,1],[1,1,1]]

"""
Example 1:

Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
Output: [[1,0,1],[0,0,0],[1,0,1]]
Example 2:

Input: matrix = [[0,1,2,0],[3,4,5,2],[1,3,1,5]]
Output: [[0,0,0,0],[0,4,5,0],[0,3,1,0]]
"""

def solve_set_matrix_zeroes(matrix):
    n = len(matrix)
    m = len(matrix[0])

    first_row_zero = any(matrix[0][j] == 0 for j in range(m))
    first_col_zero = any(matrix[i][0] == 0 for i in range(n))

    for i in range(1, n):
        for j in range(1, m):
            if matrix[i][j] == 0:
                matrix[i][0] = 0
                matrix[0][j] = 0

    for i in range(1, n):
        for j in range(1, m):
            if matrix[i][0] == 0 or matrix[0][j] == 0:
                matrix[i][j] = 0

    if first_row_zero:
        for j in range(m):
            matrix[0][j] = 0

    if first_col_zero:
        for i in range(n):
            matrix[i][0] = 0

    return matrix

print(solve_set_matrix_zeroes(matrix))
