using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Linked_List
{
    public class Node
    {
        public int val;
        public Node next;
        public Node(int data)
        {
            this.val = data;
            this.next = null;
        }
    }

    internal class Solution
    {
        public Node head;
        public void append(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
                return;
            }
            Node last = this.head;
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = newNode;
        }
        public void printList(Node head)
        {
            Node curr = head;
            while (curr != null)
            {
                Console.Write(curr.val + " ");
                curr = curr.next;
            }
        }
        public void reverse()
        {
            Node prev = null;
            Node current = this.head;
            Node nextNode = null;
            while(current != null)
            {
                nextNode = current.next;
                current.next = prev;
                prev = current;
                current = nextNode;
            }    
            this.head = prev;
        }
    }
}
