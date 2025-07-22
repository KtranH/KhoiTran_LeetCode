using System;

/*
Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
*/

namespace MergeTwoSortedLists
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
        public solve_mergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }
            current.next = list1 ?? list2;
            return dummy.next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode list1 = new ListNode();
            list1.val = 1;
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(4);
            ListNode list2 = new ListNode();
            list2.val = 1;
            list2.next = new ListNode(3);
            list2.next.next = new ListNode(4);
            ListNode result = list1.solve_mergeTwoLists(list1, list2);
            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}