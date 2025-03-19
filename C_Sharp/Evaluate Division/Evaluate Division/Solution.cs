using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluate_Division
{
    internal class Solution
    {
        public double DFS(string node, string target, double product, Dictionary<string, IList<string>> graph, HashSet<string> visited, Dictionary<string, double> values_direct)
        {
            if(!graph.ContainsKey(node) || !graph.ContainsKey(target))
            {
                return -1.0;
            }    
            if(node == target)
            {
                return product;
            }    
            visited.Add(node);
            foreach(string neighbor in graph[node])
            {
                if(visited.Contains(neighbor))
                {
                    continue;
                }    
                double result = DFS(neighbor, target, product * values_direct[node + "," + neighbor], graph, visited, values_direct);
                if(result != -1)
                {
                    return result;
                }    
            }
            return -1.0;
        }
        public double[] solve_evaluate_division()
        {
            IList<IList<string>> equations = new List<IList<string>>() { new List<string>() { "a", "b" }, new List<string>() { "b", "c" } };
            double[] values = new double[] { 2.0, 3.0 };
            IList<IList<string>> queries = new List<IList<string>>() { new List<string>() { "a", "c" }, new List<string>() { "b", "a" }, new List<string>() { "a", "e" }, new List<string>() { "a", "a" }, new List<string>() { "x", "x" } };
            double[] doubles = new double[queries.Count()];
            Dictionary<string, IList<string>> graph = new Dictionary<string, IList<string>>();
            Dictionary<string, double> values_direct = new Dictionary<string, double>();
            for (int i = 0; i < equations.Count(); i++)
            {
                string[] equation = equations[i].ToArray();
                if (!graph.ContainsKey(equation[0]))
                {
                    graph[equation[0]] = new List<string>();
                }
                if (!graph.ContainsKey(equation[1]))
                {
                    graph[equation[1]] = new List<string>();
                }
                graph[equation[0]].Add(equation[1]);
                graph[equation[1]].Add(equation[0]);
                values_direct[equation[0] + "," + equation[1]] = values[i];
                values_direct[equation[1] +  "," + equation[0]] = 1 / values[i];
            }    
            for (int i = 0; i < queries.Count(); i++)
            {
                string[] query = queries[i].ToArray();
                HashSet<string> visited = new HashSet<string>();
                doubles[i] = DFS(query[0], query[1], 1.0, graph, visited, values_direct);
            }
            return doubles;
        }
    }
}
