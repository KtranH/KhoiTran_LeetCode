/*Example 1:


Input: isConnected = [[1,1,0],[1,1,0],[0,0,1]]
Output: 2
Example 2:


Input: isConnected = [[1,0,0],[0,1,0],[0,0,1]]
Output: 3*/

isConnected = [[1,1,0],[1,1,0],[0,0,1]]
visited = new Array(isConnected.length).fill(false);
let count = 0;

function DFS(isConnected, visited, index)
{
    if(visited[index]) return;
    visited[index] = true;
    for(let i = 0; i < isConnected.length; i++)
    {
        if(isConnected[index][i] == 1)
        {
            DFS(isConnected, visited, i);
        }
    }
}
function solve_number_of_provinces()
{
    for(let i = 0; i < isConnected.length; i++)
    {
        if(!visited[i])
        {
            count++;
            DFS(isConnected, visited, i);
        }
    }
    return count;
}

console.log(solve_number_of_provinces());
