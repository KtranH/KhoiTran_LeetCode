using System;

/*

Example 1:

Input: head = [1,2,3,4,5], left = 2, right = 4
Output: [1,4,3,2,5]

Example 2:

Input: head = [5], left = 1, right = 1
Output: [5]

*/
namespace ReverseLinkedListII
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
        public solve_reverse_linked_list_ii(ListNode head, int left, int right)
        {
            if (head == null || left == right)
            {
                return head;
            }

            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode prev = dummy;

            for (int i = 1; i < left; i++)
            {
                prev = prev.next;
            }
            
            ListNode curr = prev.next;
            ListNode reverse = null;

            for (int i = 0; i < right - left + 1; i++)
            {
                ListNode next_node = curr.next;
                curr.next = reverse;
                reverse = curr;
                curr = next_node;
            }

            prev.next.next = curr;
            prev.next = reverse;
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
            
            int left = 2;
            int right = 4;
            
            ListNode result = head.solve_reverse_linked_list_ii(head, left, right);
            
            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
            Console.ReadKey();
        }
    }
}
