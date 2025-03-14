using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys_and_Rooms
{
    internal class Solution
    {
        public bool solve_keys_and_rooms()
        {
            List<List<int>> rooms = new List<List<int>>() { new List<int>() { 1 }, new List<int>() { 2 }, new List<int>() { 3 }, new List<int>() { } };
            bool[] visited = new bool[rooms.Count];
            this.dfs(rooms, visited, 0);
            foreach(bool room in visited)
            {
                if(!room)
                {
                    return false;
                }
            }    
            return true;
        }
        public void dfs(List<List<int>> rooms, bool[] visited, int key)
        {
            if(visited[key])
            {
                return;
            }    
            visited[key] = true;
            foreach(int room in rooms[key])
            {
                dfs(rooms, visited, room);
            }
        }
    }
}
