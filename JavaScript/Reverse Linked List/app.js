/*Example 1:


Input: head = [1,2,3,4,5]
Output: [5,4,3,2,1]
Example 2:


Input: head = [1,2]
Output: [2,1]
Example 3:

Input: head = []
Output: []*/
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
        if(!this.head)
        {
            this.head = newNode;
            return;
        }
        let current = this.head;
        while(current.next)
        {
            current = current.next;
        }
        current.next = newNode;
    }
    display()
    {
        let current = this.head;
        while(current)
        {
            console.log(current.val);
            current = current.next;
        }
    }
    reverse()
    {
        let prev = null;
        let current = this.head;
        let next = null;
        while(current)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        this.head = prev;
    }
}

let test = new ListNode();
test.append(1);
test.append(2);
test.append(3);
test.reverse();
test.display();