/*Example 1:


Input: head = [1,3,4,7,1,2,6]
Output: [1,3,4,1,2,6]
Explanation:
The above figure represents the given linked list. The indices of the nodes are written below.
Since n = 7, node 3 with value 7 is the middle node, which is marked in red.
We return the new list after removing this node. 
Example 2:


Input: head = [1,2,3,4]
Output: [1,2,4]
Explanation:
The above figure represents the given linked list.
For n = 4, node 2 with value 3 is the middle node, which is marked in red.
Example 3:


Input: head = [2,1]
Output: [2]
Explanation:
The above figure represents the given linked list.
For n = 2, node 1 with value 1 is the middle node, which is marked in red.
Node 0 with value 2 is the only node remaining after removing node 1.*/
class Node
{
    constructor(val)
    {
        this.data = val;
        this.next = null;
    }
}
class ListNode
{
    constructor()
    {
        this.head = null;
    }
    append(data)
    {
        let newNode = new Node(data);
        if (!this.head) {
            this.head = newNode;
            return;
        }
        let current = this.head;
        while (current.next) {
            current = current.next;
        }
        current.next = newNode;
    }
    display()
    {
        let current = this.head;
        while (current) {
            console.log(current.data);
            current = current.next;
        }
    }
    delete_middle()
    {
        if (!this.head ||!this.head.next) return;
        let slow = this.head, fast = this.head.next, prev = null;
        while (fast && fast.next) {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        prev.next = slow.next;
    }
}

let test = new ListNode();
test.append(1);
test.append(2);
test.append(3);
test.delete_middle();
test.display();