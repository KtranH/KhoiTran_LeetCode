using System;

/*
Example 1:

Input: head = [3,2,0,-4], pos = 1
Output: true
Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).
Example 2:

Input: head = [1,2], pos = 0
Output: true
Explanation: There is a cycle in the linked list, where the tail connects to the 0th node.
Example 3:

Input: head = [1], pos = -1
Output: false
Explanation: There is no cycle in the linked list.
*/

namespace LinkedListCycle
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
        // Thêm phần tử vào cuối danh sách
        public void Append(int val)
        {
            Node newNode = new Node(val);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }
        // In ra danh sách
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.val + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
        // Kiểm tra xem danh sách có chứa chu kỳ không
        public bool HasCycle()
        {
            Node slow = head;
            Node fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);
            list.PrintList();
            Console.WriteLine(list.HasCycle());
        }
    }
}