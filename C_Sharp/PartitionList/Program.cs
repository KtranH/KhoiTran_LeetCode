using System;

/*
Example 1:

Input: head = [1,4,3,2,5,2], x = 3
Output: [1,2,2,4,3,5]
Example 2:

Input: head = [2,1], x = 2
Output: [1,2]
*/

namespace PartitionList
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
        public ListNode solve_partition_list(ListNode head, int x)
        {
            if(head == null || head.next == null)
            {
                return head;
            }
            
            ListNode before_head = new ListNode(0);
            ListNode after_head = new ListNode(0);
            
            ListNode before = before_head;
            ListNode after = after_head;
            
            while(head != null)
            {
                if(head.val < x)
                {
                    before.next = head;
                    before = before.next;
                }
                else
                {
                    after.next = head;
                    after = after.next;
                }
                head = head.next;
            }
            after.next = null;
            before.next = after_head.next;
            return before_head.next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(4);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(2);
            head.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next = new ListNode(2);
            
            ListNode result = head.solve_partition_list(head, 3);
            
            while(result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
            Console.WriteLine();
        }
    }
}