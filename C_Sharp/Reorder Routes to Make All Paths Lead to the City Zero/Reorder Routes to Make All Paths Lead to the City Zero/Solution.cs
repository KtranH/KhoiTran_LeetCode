using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Reorder_Routes_to_Make_All_Paths_Lead_to_the_City_Zero
{
    internal class Solution
    {        
        public int DFS(int node, HashSet<(int, int)> directEdges, Dictionary<int, List<int>> graph, bool[] visited) {
            int count = 0;
            foreach (var neighbor in graph[node])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    if (directEdges.Contains((node, neighbor))) count++;
                    count += DFS(neighbor, directEdges, graph, visited);
                }
            }
            return count;
        }
        public int solve_reorder_routes()
        {
            int[][] connections = new int[][] { new int[] { 0, 1 }, new int[] { 1, 2 }, new int[] { 2, 0 } };
            int n = 6;
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            HashSet<(int, int)> directEdges = new HashSet<(int, int)>();
            bool[] visited = new bool[n];
            foreach (var conn in connections)
            {
                int u = conn[0], v = conn[1];
                if (!graph.ContainsKey(u)) graph[u] = new List<int>();
                if (!graph.ContainsKey(v)) graph[v] = new List<int>();
                graph[u].Add(v);
                graph[v].Add(u);
                directEdges.Add((u, v));
            }      
            visited[0] = true;
            int count = DFS(0, directEdges, graph, visited);
            return count;
        }
    }
}
