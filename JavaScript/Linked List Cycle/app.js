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


class Node {
    // Khởi tạo nút
    constructor(val) {
        this.val = val;
        this.next = null;
    }
}

class LinkedList
{
    constructor()
    {
        this.head = null;
    }
    // Thêm phần tử vào cuối danh sách
    append(val)
    {
        let newNode = new Node(val);
        if (!this.head)
        {
            this.head = newNode;
            return;
        }
        let current = this.head;
        while (current.next)
        {
            current = current.next;
        }
        current.next = newNode;
    }
    // In ra danh sách
    printList()
    {
        let current = this.head;
        while (current)
        {
            console.log(current.val);
            current = current.next;
        }
    }
    // Kiểm tra xem danh sách có chứa chu kỳ không
    hasCycle()
    {
        let slow = this.head;
        let fast = this.head;
        while (fast && fast.next)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow === fast)
            {
                return true;
            }
        }
        return false;
    }
}

let list = new LinkedList();
list.append(1);
list.append(2);
list.append(3);
list.append(4);
list.append(5);
list.printList();
console.log(list.hasCycle());
