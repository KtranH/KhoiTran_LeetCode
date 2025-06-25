board = [[0,1,0],[0,0,1],[1,1,1],[0,0,0]]

"""
Example 1:

Input: board = [[0,1,0],[0,0,1],[1,1,1],[0,0,0]]
Output: [[0,0,0],[0,0,0],[1,1,1],[0,0,0]]
Example 2:

Input: board = [[1,1,0],[1,0,1],[0,1,1]]
Output: [[1,1,0],[1,0,1],[0,1,1]]
"""
import copy
def solve_game_of_life(board):
    board_temp = copy.deepcopy(board)
    n = len(board)
    m = len(board[0])
    # Rẽ 8 hướng: Trái, Trái trên, Trái dưới, Phải, Phải trên, Phải dưới, Dưới, Dưới trái
    direction = [(-1, -1), (-1, 0), (-1, 1),
                  (0, -1),           (0, 1),
                  (1, -1),  (1, 0),  (1, 1)]
    for i in range(n):
        for j in range(m):
            live = 0 
            for dx, dy in direction:
                x = i + dx
                y = j + dy
                if 0 <= x < n and 0 <= y < m and board[x][y] == 1:
                    live += 1
            if board[i][j] == 1 and (live < 2 or live > 3):
                board_temp[i][j] = 0
            elif board[i][j] == 0 and live == 3:
                board_temp[i][j] = 1
    return board_temp

print(solve_game_of_life(board))

                