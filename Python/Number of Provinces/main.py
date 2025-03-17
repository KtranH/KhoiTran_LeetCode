"""
Example 1:


Input: isConnected = [[1,1,0],[1,1,0],[0,0,1]]
Output: 2
Example 2:


Input: isConnected = [[1,0,0],[0,1,0],[0,0,1]]
Output: 3

isConnected = [[1,1,0],[1,1,0],[0,0,1]]
v = [False] * len(isConnected)
count = 0
"""

def dfs(isConnected, v, i):
    if v[i]:
        return
    v[i] = True
    for j in range(len(isConnected)):
        if isConnected[i][j] == 1:
            dfs(isConnected, v, j)

def solve_number_of_provinces(isConnected, v, count):
    for i in range(len(isConnected)):
        if not v[i]:
            dfs(isConnected, v, i)
            count += 1
    return count

print(solve_number_of_provinces(isConnected, v, count))