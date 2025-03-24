using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kth_Largest_Element_in_an_Array
{
    internal class Solution
    {
        /*static int QuickSelect(int[] nums, int left, int right, int k)
        {
            int pivotIndex = Partition(nums, left, right);

            if (pivotIndex == k)
                return nums[pivotIndex]; 

            if (pivotIndex < k)
                return QuickSelect(nums, pivotIndex + 1, right, k); 

            return QuickSelect(nums, left, pivotIndex - 1, k);  
        }

        static int Partition(int[] nums, int left, int right)
        {
            int pivot = nums[right]; 
            int i = left; 

            for (int j = left; j < right; j++)
            {
                if (nums[j] >= pivot)
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]); 
                    i++;
                }
            }

            (nums[i], nums[right]) = (nums[right], nums[i]); 
            return i;
        }
        public int solve_kth_largest_element_in_an_array(int[] nums, int k)
        {
            return QuickSelect(nums, 0, nums.Length - 1, k - 1);
        }*/
        static void Heapify(int[] heap, int n, int i)
        {
            int smallest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && heap[left] < heap[smallest])
                smallest = left;

            if (right < n && heap[right] < heap[smallest])
                smallest = right;

            if (smallest != i)
            {
                int swap = heap[i];
                heap[i] = heap[smallest];
                heap[smallest] = swap;

                Heapify(heap, n, smallest);
            }
        }
        public int solve_kth_largest_element_in_an_array(int[] nums, int k)
        {
            int[] heap = new int[k];

            for (int i = 0; i < k; i++)
            {
                heap[i] = nums[i];
            }

            for (int i = k / 2 - 1; i >= 0; i--)
            {
                Heapify(heap, k, i);
            }

            for (int i = k; i < nums.Length; i++)
            {
                if (nums[i] > heap[0])
                {
                    heap[0] = nums[i];
                    Heapify(heap, k, 0);
                }
            }
            return heap[0];
        }
    }
}
