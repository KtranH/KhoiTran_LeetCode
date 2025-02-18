"""
Example 1:


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
- (Row 3, Column 2): [2,4,2,2]
"""

grid = [[13,13],[13,13]]

"""
def solve_equal_row_and_column_pairs(grid):
    hashmap = {}
    count = 0
    length_grid = len(grid)
    for i in range(length_grid):
        list_tuple = []
        for j in range(length_grid):
            list_tuple.append(grid[i][j])
        if tuple(list_tuple) in hashmap:
            hashmap[tuple(list_tuple)] += 1
        else:
            hashmap[tuple(list_tuple)] = 1
    for i in range(length_grid):
        list_tuple = []
        for j in range(length_grid):
            list_tuple.append(grid[j][i])
        if tuple(list_tuple) in hashmap:
            count += hashmap[tuple(list_tuple)]
    return count
"""
def solve_equal_row_and_column_pairs(grid):
    n = len(grid)
    row_counts = {}
    
    for i in range(n):
        row_tuple = tuple(grid[i]) 
        row_counts[row_tuple] = row_counts.get(row_tuple, 0) + 1
    
    count = 0
    for j in range(n):
        col_tuple = tuple(grid[i][j] for i in range(n)) 
        count += row_counts.get(col_tuple, 0)  
    
    return count

print(solve_equal_row_and_column_pairs(grid))