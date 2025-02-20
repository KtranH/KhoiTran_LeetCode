using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroid_Collision
{
    public class Solution
    {
        public int[] solve_asteroid_collision(int[] asteroids) { 
            Stack<int> stack = new Stack<int>();
            foreach (int a in asteroids)
            {
                if(a > 0) stack.Push(a);
                else
                {
                    while(stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < -a) stack.Pop();
                    if(stack.Count == 0 || stack.Peek() < 0) stack.Push(a);
                    else if (stack.Peek() == -a) stack.Pop();
                }    
            }
            return stack.Reverse().ToArray();
        }
    }
}
