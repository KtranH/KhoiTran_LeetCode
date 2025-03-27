using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Cost_to_Hire_K_Workers
{
    internal class Solution
    {
        public int[] costs = { 1, 3 };
        public int k = 1;
        public int candidates = 1;

        private int Parent(int i) => (i - 1) / 2;
        private int LeftChild(int i) => 2 * i + 1;
        private int RightChild(int i) => 2 * i + 2;
        private void Heapify(int i, List<int> heap)
        {
            int left = LeftChild(i), right = RightChild(i), smallest = i;
            if (left < heap.Count && heap[left] < heap[smallest]) smallest = left;
            if (right < heap.Count && heap[right] < heap[smallest]) smallest = right;

            if (smallest != i)
            {
                (heap[i], heap[smallest]) = (heap[smallest], heap[i]);
                Heapify(smallest, heap);
            }
        }
        public void Insert(int val, List<int> heap)
        {
            heap.Add(val);
            int i = heap.Count - 1;
            while (i > 0 && heap[i] < heap[Parent(i)])
            {
                (heap[i], heap[Parent(i)]) = (heap[Parent(i)], heap[i]); // Swap
                i = Parent(i);
            }
        }
        public int PeekMin(List<int> heap)
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap rỗng");
            return heap[0];
        }
        public int RemoveMin(List<int> heap)
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap rỗng");

            int minValue = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            Heapify(0, heap);
            return minValue;
        }
        public long solve_total_cost_to_hire_k_workers(int[] costs, int k, int candidates)
        {
            long total_cost = 0;
            List<int> min_left_heap = new List<int>();
            List<int> min_right_heap = new List<int>();
            LinkedList<int> dq = new LinkedList<int>(costs);
            for (int i = 0; i < Math.Min(costs.Length, candidates); i++)
            {
                if(dq.Count > 0)
                {
                    Insert(dq.First.Value, min_left_heap);
                    dq.RemoveFirst();
                }    
            }
            for (int i = 0; i < Math.Min(costs.Length, candidates); i++)
            {
                if (dq.Count > 0)
                {
                    Insert(dq.Last.Value, min_right_heap);
                    dq.RemoveLast();
                }
            }
            for (int i = 0; i < k; i++)
            {
                if (min_right_heap.Count == 0 || (min_left_heap.Count > 0 && min_left_heap[0] <= min_right_heap[0]))
                {
                    total_cost += RemoveMin(min_left_heap);
                    if (dq.Count > 0)
                    {
                        Insert(dq.First.Value, min_left_heap);
                        dq.RemoveFirst();
                    }
                }
                else
                {
                    total_cost += RemoveMin(min_right_heap);
                    if (dq.Count > 0)
                    {
                        Insert(dq.Last.Value, min_right_heap);
                        dq.RemoveLast();
                    }
                }    
            }    
            return total_cost;
        }
    }
}
