using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Linked_List
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
        public Node head = null;
        public void append(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                return;
            }
            else
            {
                Node last = head;
                while (last.next != null)
                {
                    last = last.next;
                }
                last.next = newnode;
            }
        }
        public void display()
        {
            Node node = this.head;
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
        }
        public void solve_odd_even_linked_list()
        {
            if (this.head == null) return;
            Node Odd = null;
            Node Odd_head = null;
            Node even = null;
            Node even_head = null;
            Node node = this.head;
            bool is_even = false;
            while (node != null)
            {
                if(is_even)
                {
                    if(even_head == null)
                    {
                        even_head = node;
                        even = node;
                    } else
                    {
                        even.next = node;
                        even = even.next;
                    }
                }    
                else
                {
                    if (Odd_head == null)
                    {
                        Odd_head = node;
                        Odd = node; 
                    }
                    else
                    {
                        Odd.next = node;
                        Odd = Odd.next;
                    }
                }    
                is_even = !is_even;
                node = node.next;
            }    
            if (Odd != null)
            {
                Odd.next = even_head;
            }
            if(even != null)
            {
                even.next = null;
            }
            if(Odd_head != null)
            {
                this.head = Odd_head;
            }    
            else
            {
                this.head = even_head;
            }    
        }
    }
}
