using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Example 1:

Input: path = "/home//foo/"
Output: "/home/foo"
Explanation: In the canonical path, multiple slashes are replaced by a single one.
Example 2:

Input: path = "/a/./b/../../c/"
Output: "/c"
*/

namespace SimplifyPath
{
    class Program
    {
        static string solve_simplify_path(string path)
        {
            string[] tokens = path.Split('/');
            Stack<string> stack = new Stack<string>();
            foreach (string token in tokens)
            {
                if (token == "" || token == ".")
                {
                    continue;
                }
                else if (token == "..")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(token);
                }
            }
            return "/" + string.Join("/", stack.Reverse()); 
        }
        static void Main(string[] args)
        {
            string path = "/home//foo/";
            Console.WriteLine(solve_simplify_path(path));
            Console.ReadKey();
        }
    }
}