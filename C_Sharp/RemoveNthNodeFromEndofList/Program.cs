using System;

/*
Example 1:

Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]
Example 2:

Input: head = [1], n = 1
Output: []
Example 3:

Input: head = [1,2], n = 1
Output: [1]
*/

namespace Solution
{
    class ListNode
    {
        public int val = 0;
        public ListNode next = null;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public ListNode solve_remove_nth_node_from_end_of_list(ListNode head, int n)
        {
            if (head == null || n <= 0)
            {
                return head;
            }
            
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            
            ListNode first = dummy;
            ListNode second = dummy;   
            
            for (int i = 0; i < n; i++)
            {
                first = first.next;
            }
            
            while (first.next != null)
            {
                first = first.next;
                second = second.next;
            }
            
            second.next = second.next.next;
            
            return dummy.next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            
            int n = 2;
            
            ListNode result = head.solve_remove_nth_node_from_end_of_list(head, n);
            
            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}