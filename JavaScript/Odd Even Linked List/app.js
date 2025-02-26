/*Example 1:


Input: head = [1,2,3,4,5]
Output: [1,3,5,2,4]
Example 2:


Input: head = [2,1,3,5,6,4,7]
Output: [2,3,6,7,1,5,4]*/

class Node
{
    constructor(data)
    {
        this.data = data;
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
    solve_odd_even_linked_list()
    {
        if (!this.head) return;
        let odd = null;
        let odd_head = null;
        let even = null;
        let even_head = null;
        let is_even = false;
        let node = this.head;

        while (node) {
            if (is_even) {
                if (!even_head) {
                    even_head = node;
                    even = node;
                } else {
                    even.next = node;
                    even = even.next;
                }
            } else {
                if (!odd_head) {
                    odd_head = node;
                    odd = node;
                } else {
                    odd.next = node;
                    odd = odd.next;
                }
            }
            node = node.next;
            is_even = !is_even;
        }
        if (odd) odd.next = even_head;
        if (even) even.next = null;
        if (odd_head) this.head = odd_head;
        else this.head = even_head;
    }
}

let test = new ListNode();
test.append(1);
test.append(2);
test.append(3);
test.solve_odd_even_linked_list();
test.display(); // Output: 1, 2, 3