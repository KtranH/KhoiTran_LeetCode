using System;

/*
Input: head = [[7,null],[13,0],[11,4],[10,2],[1,0]]
Output: [[7,null],[13,0],[11,4],[10,2],[1,0]]
*/

namespace CopyListwithRandomPointer
{
    class Node
    {
        public int val;
        public Node next;
        public Node random;
        public Node(int val)
        {
            this.val = val;
            this.next = null;
            this.random = null;
        }
        public Node solve_copyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }
            
            Node curr = head;
            while (curr != null)
            {
                Node copy = new Node(curr.val);
                copy.next = curr.next;
                curr.next = copy;
                curr = copy.next;
            }

            curr = head;
            while (curr != null)
            {
                if (curr.random != null)
                {
                    curr.next.random = curr.random.next;
                }
                curr = curr.next.next;
            }

            Node pseudo_head = new Node(0);
            Node copy_curr = pseudo_head;
            curr = head;

            while (curr != null)
            {
                Node copy = curr.next;
                copy_curr.next = copy;
                copy_curr = copy;

                curr.next = copy.next;
                curr = curr.next;
            }

            return pseudo_head.next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(4);
            head.next.next.next.next = new Node(5);
            head.random = head.next.next;
            head.next.random = head;
            head.next.next.random = head.next.next.next.next;
            head.next.next.next.random = head.next;
            head.next.next.next.next.random = head;
            Node copy = head.solve_copyRandomList(head);
            copy.printList();
        }
    }
}
