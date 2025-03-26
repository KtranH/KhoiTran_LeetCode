using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Subsequence_Score
{
    internal class Solution
    {
        private List<int> heap = new List<int>();
        public int[] nums1 = new int[] { 1, 3, 3, 2 };
        public int[] nums2 = new int[] { 2, 1, 3, 4 };
        public int k = 3;
        private int Parent(int i) => (i - 1) / 2;
        private int LeftChild(int i) => 2 * i + 1;
        private int RightChild(int i) => 2 * i + 2;
        private void Heapify(int i)
        {
            int left = LeftChild(i), right = RightChild(i), smallest = i;
            if (left < heap.Count && heap[left] < heap[smallest]) smallest = left;
            if (right < heap.Count && heap[right] < heap[smallest]) smallest = right;

            if (smallest != i)
            {
                (heap[i], heap[smallest]) = (heap[smallest], heap[i]);
                Heapify(smallest);
            }
        }
        public void Insert(int val)
        {
            heap.Add(val);
            int i = heap.Count - 1;
            while (i > 0 && heap[i] < heap[Parent(i)])
            {
                (heap[i], heap[Parent(i)]) = (heap[Parent(i)], heap[i]); // Swap
                i = Parent(i);
            }
        }
        public int PeekMin()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap rỗng");
            return heap[0];
        }
        public int RemoveMin()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap rỗng");

            int minValue = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            Heapify(0);
            return minValue;
        }
        public long solve_maximum_subsequence_score(int[] nums1, int[] nums2, int k) {
            int[] indices = Enumerable.Range(0, nums2.Length).ToArray();
            Array.Sort(indices, (a, b) => nums2[b].CompareTo(nums2[a]));
            long sum_selected = 0;
            long max_score = 0;
            foreach(int i in indices) {
                if(this.heap.Count < k) {
                    this.Insert(nums1[i]);
                    sum_selected += nums1[i];
                } else if(this.PeekMin() < nums1[i]) {
                    sum_selected += nums1[i] - this.RemoveMin();
                    this.Insert(nums1[i]);
                }
                if (this.heap.Count == k) {
                    max_score = Math.Max(max_score, sum_selected * (long)nums2[i]);
                }
            }
            return max_score;
        }
    }
}
