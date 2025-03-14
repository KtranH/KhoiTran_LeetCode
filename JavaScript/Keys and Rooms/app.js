/*Example 1:

Input: rooms = [[1],[2],[3],[]]
Output: true
Explanation: 
We visit room 0 and pick up key 1.
We then visit room 1 and pick up key 2.
We then visit room 2 and pick up key 3.
We then visit room 3.
Since we were able to visit every room, we return true.
Example 2:

Input: rooms = [[1,3],[3,0,1],[2],[0]]
Output: false
Explanation: We can not enter room number 2 since the only key that unlocks it is in that room.*/

let rooms = [[1], [2], [3], []];
let v = new Array(rooms.length).fill(false);

function dfs(rooms, v, key)
{
    if(v[key])
    {
        return;
    }
    v[key] = true;
    for(let i = 0; i < rooms[key].length; i++)
    {
        dfs(rooms, v, rooms[key][i]);
    }
}
function solve_keys_and_rooms(rooms, v, key)
{
    dfs(rooms, v, key);
    for(let i = 0; i < v.length; i++)
    {
        if(!v[i])
        {
            return false;
        }
    }
    return true;
}
console.log(solve_keys_and_rooms(rooms, v, 0))