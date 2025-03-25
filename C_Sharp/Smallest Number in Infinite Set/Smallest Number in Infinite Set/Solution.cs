using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Number_in_Infinite_Set
{
    internal class Solution
    {
        public void solve_smallest_number_in_infinite_set()
        {
            SortedSet<int> heap = new SortedSet<int>();
            int smallest = 1;
            HashSet<int> addedBack = new HashSet<int>();
        }
        public int PopSmallest(SortedSet<int> heap, HashSet<int> addedBack, int smallest)
        {
            if(heap.Count != 0)
            {
                int small = heap.Min;
                heap.Remove(small);
                addedBack.Remove(small);
                return small;
            }
            else
            {
                int small = smallest;
                smallest++;
                return small;
            }    
        }
        public void AddBack(int num, SortedSet<int> heap, HashSet<int> addedBack, int smallest)
        {
            if(num < smallest && !addedBack.Contains(num))
            {
                heap.Add(num);
                addedBack.Add(num);
            }
        }
    }
}
 