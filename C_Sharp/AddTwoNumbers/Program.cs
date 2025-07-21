using System;

/*
Example 1:

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
*/

namespace AddTwoNumbers
{
    class Node
    {
        public int val;
        public Node next;
        public Node(int val)
        {
            this.val = val;
            this.next = null;
        }
    }
    class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            this.head = null;
        }
        public LinkedList solve_add_two_numbers(LinkedList l1, LinkedList l2)
        {
            LinkedList dummy_head = new LinkedList(0);
            Node current = dummy_head;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                current.next = new Node(sum % 10);
                current = current.next;
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }
            if (carry > 0)
            {
                current.next = new Node(carry);
            }
            return dummy_head.next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList l1 = new LinkedList();
            l1.append(2);
            l1.append(4);
            l1.append(3);
            LinkedList l2 = new LinkedList();
            l2.append(5);
            l2.append(6);
            l2.append(4);
            LinkedList result = l1.solve_add_two_numbers(l1, l2);
            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
            Console.ReadKey();
        }
    }
}
