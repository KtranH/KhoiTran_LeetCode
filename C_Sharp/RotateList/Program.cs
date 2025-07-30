using System;

/*
Example 1:

Input: head = [1,2,3,4,5], k = 2
Output: [4,5,1,2,3]
Example 2:

Input: head = [0,1,2], k = 4
Output: [2,0,1]
*/

namespace RotateList
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
        public  solve_rotate_list(ListNode head, int k)
        {
            if (head == null || head.next == null || k == 0)
            {
                return head;
            }
            
            int length = 1;
            ListNode tail = head;
            while (tail.next != null)
            {
                length++;
                tail = tail.next;
            }
            
            k = k % length;
            if (k == 0)
            {
                return head;
            }
            
            int stepsToNewHead = length - k;
            ListNode prev = null;
            ListNode current = head;
            for (int i = 0; i < stepsToNewHead; i++)
            {
                prev = current;
                current = current.next;
            }
            
            prev.next = null;
            tail.next = head;
            head = current;
            
            return head;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode = new ListNode();
            listNode.solve_rotate_list(head, k);
            Console.WriteLine(listNode);
            Console.ReadKey();
        }
    }
}