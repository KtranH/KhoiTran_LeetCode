/*
Input: head = [[7,null],[13,0],[11,4],[10,2],[1,0]]
Output: [[7,null],[13,0],[11,4],[10,2],[1,0]]
*/

class Node
{
    constructor(val)
    {
        this.val = val;
        this.next = null;
        this.random = null;
    }
    solve_copyRandomList(head)
    {
        if (head == null)
        {
            return null;
        }
     
        let curr = head;
        while (curr != null)
        {
            let copy = new Node(curr.val);
            copy.next = curr.next;
            curr.next = copy;
            curr = copy.next;
        }

        curr = head;
        while (curr != null)
        {
            if (curr.random != null)
            {
                curr.next.random = curr.random.next;
            }
            curr = curr.next.next;
        }

        let pseudo_head = new Node(0);
        let copy_curr = pseudo_head;
        curr = head;

        while (curr != null)
        {
            let copy = curr.next;
            copy_curr.next = copy;
            copy_curr = copy;

            curr.next = copy.next;
            curr = curr.next;
        }

        return pseudo_head.next;
    }
}