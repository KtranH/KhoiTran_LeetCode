using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Recent_Calls
{
    public class Solution
    {
        public Queue<int> queue;
        public Solution()
        {
            queue = new Queue<int>();
        }
        public int Ping(int t) {
            this.queue.Enqueue(t);
            while (this.queue.Peek() < t - 3000)
            {
                this.queue.Dequeue();
            }
            return this.queue.Count;
        }
    }
}
