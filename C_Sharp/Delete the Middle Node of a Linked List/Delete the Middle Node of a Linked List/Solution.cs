using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete_the_Middle_Node_of_a_Linked_List
{
    public class Node
    {
        public int value;
        public Node next;
        public Node (int data)
        {
            this.value = data;
            this.next = null;
        }
    }
    public class Solution
    {
        public Node head;
        public void Append_Node(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
                return;
            }
            Node current = head;
            while(current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }
        public void Display()
        {
            Node current = head;
            while(current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
        public void Delete_Middle()
        {
            if (this.head == null || this.head.next == null)
            {
                return;
            }
            Node fast = this.head;
            Node slow = this.head;
            Node prev = null;
            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            prev.next = slow.next;
        }
    }
}
