/*
Example 1:

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
*/

class LinkedList
{
    constructor(val, next)
    {
        this.val = (val == undefined ? 0 : val);
        this.next = (next == undefined ? null : next);
    }
    solve_add_two_numbers(l1, l2)
    {
        let dummy_head = new LinkedList(0);
        let current = dummy_head;
        let carry = 0;
        while (l1 != null || l2 != null)
        {
            let x = (l1 != null) ? l1.val : 0;
            let y = (l2 != null) ? l2.val : 0;
            let sum = carry + x + y;
            carry = Math.floor(sum / 10);
            current.next = new LinkedList(sum % 10);
            current = current.next;
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }
        if (carry > 0)
        {
            current.next = new LinkedList(carry);
        }
        return dummy_head.next;
    }
}

let l1 = new LinkedList(2, new LinkedList(4, new LinkedList(3)));
let l2 = new LinkedList(5, new LinkedList(6, new LinkedList(4)));
let result = l1.solve_add_two_numbers(l1, l2);
while (result != null)
{
    console.log(result.val);
    result = result.next;
}
