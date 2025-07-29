using System;

/*
Example 1:

Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]
Example 2:

Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]
*/

namespace RemoveNthNodeFromEndofListII
{
    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public solve_remove_nth_node_from_end_of_list_ii(ListNode head, int n)
        {
            if (head == null)
            {
                return head;
            }
            
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode prev = dummy;

            while(prev.next != null && prev.next.next != null)
            {
                if(prev.next.val == prev.next.next.val)
                {
                    int dup_val = prev.next.val;
                    while(prev.next != null && prev.next.val == dup_val)
                    {
                        prev.next = prev.next.next;
                    }
                }
                else
                {
                    prev = prev.next;
                }
            }   
            return dummy.next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5 };
            ListNode head = new ListNode(values[0]);
            for (int i = 1; i < values.Length; i++)
            {
                head.next = new ListNode(values[i]);
            }
            int n = 2;
            ListNode result = new ListNode().solve_remove_nth_node_from_end_of_list_ii(head, n);
            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
