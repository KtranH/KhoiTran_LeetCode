/*Example 1:


Input: head = [5,4,2,1]
Output: 6
Explanation:
Nodes 0 and 1 are the twins of nodes 3 and 2, respectively. All have twin sum = 6.
There are no other nodes with twins in the linked list.
Thus, the maximum twin sum of the linked list is 6. 
Example 2:


Input: head = [4,2,2,3]
Output: 7
Explanation:
The nodes with twins present in this linked list are:
- Node 0 is the twin of node 3 having a twin sum of 4 + 3 = 7.
- Node 1 is the twin of node 2 having a twin sum of 2 + 2 = 4.
Thus, the maximum twin sum of the linked list is max(7, 4) = 7. 
Example 3:


Input: head = [1,100000]
Output: 100001
Explanation:
There is only one node with a twin in the linked list having twin sum of 1 + 100000 = 100001.*/
class Node
{
    constructor(data)
    {
        this.val = data;
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
            console.log(current.val);
            current = current.next;
        }
    }
    findMiddle(head)
    {
        let slow = head;
        let fast = head;
        while (fast && fast.next) {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
    reverse(slow_node)
    {
        let prev = null;
        let current = slow_node;
        while (current) {
            let next_node = current.next;
            current.next = prev;
            prev = current;
            current = next_node;
        }
        return prev;
    }
    solve_maximum_twin_sum_of_a_linked_list()
    {
        let first = this.head;
        let middle = this.findMiddle(this.head);
        middle = this.reverse(middle);
        let max = 0;
        while (middle) {
            let temp = first.val + middle.val;
            if(max < temp) max = temp;
            first = first.next;
            middle = middle.next;
        }
        return max;
    }
}

let list = new ListNode();
list.append(5);
list.append(4);
list.append(2);
list.append(1);
console.log(list.solve_maximum_twin_sum_of_a_linked_list());