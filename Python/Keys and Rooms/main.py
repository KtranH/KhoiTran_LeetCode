rooms = [[1], [2], [3], []]
v = [False] * len(rooms)

def dfs(rooms, v, key):
    if v[key]:
        return
    v[key] = True
    for i in rooms[key]:
        dfs(rooms, v, i)
def solve_keys_and_rooms(rooms, v, key):
    dfs(rooms, v, key)
    return all(v)

print(solve_keys_and_rooms(rooms, v, 0))

"""
Example 1:

Input: rooms = [[1],[2],[3],[4],[]]
Output: true
Explanation: 
We will visit room 0 and pick up key 1.
We will visit room 1 and pick up key 2.
We will visit room 2 and pick up key 3.
We will visit room 3 and pick up key 4.
We will visit room 4 and finish.

Example 2:

Input: rooms = [[1,3],[3,0,1],[2],[0]]
Output: false
Explanation: We can not enter room number 2 since the only key that unlocks it is in that room.
"""
