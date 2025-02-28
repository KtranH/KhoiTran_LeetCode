using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Twin_Sum_of_a_Linked_List
{
    public class Node
    {
        public int val;
        public Node next;
        public Node(int val)
        {
            this.val = val;
            this.next = null;
        }
    }
    internal class Solution
    {
        public Node head = null;
        public void append(int val)
        {
            Node newNode = new Node(val);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node last = head;
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = newNode;
        }
        public void display(Node head)
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.val + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        public Node findMiddle(Node slow_node)
        {
            Node slow = this.head;
            Node fast = this.head;
            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
        public Node reverse(Node slow_node)
        {
            Node prev = null;
            Node curr = slow_node;
            Node next = null;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }
        public int solve_maximum_twin_sum_of_a_linked_list()
        {
            Node prev = this.head;
            Node after = reverse(findMiddle(this.head));
            int max = 0;
            while(after != null)
            {
                int temp_sum = prev.val + after.val;
                if (temp_sum > max)
                {
                    max = temp_sum;
                }
                prev = prev.next;
                after = after.next;
            }
            return max;
        }
    }
}
