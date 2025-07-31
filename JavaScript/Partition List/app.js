/*
Example 1:

Input: head = [1,4,3,2,5,2], x = 3
Output: [1,2,2,4,3,5]
Example 2:

Input: head = [2,1], x = 2
Output: [1,2]
*/

function ListNode(val, next)
{
    this.val = (val === undefined ? 0 : val);
    this.next = (next === undefined ? null : next);
}

function solve_partition_list(head, x)
{
    if(head == null || head.next == null)
    {
        return head;
    }
    
    let before_head = new ListNode(0);
    let after_head = new ListNode(0);
    
    let before = before_head;
    let after = after_head;
    
    while(head != null)
    {
        if(head.val < x)
        {
            before.next = head;
            before = before.next;
        }
        else
        {
            after.next = head;
            after = after.next;
        }
        head = head.next;
    }
    after.next = null;
    before.next = after_head.next;
    return before_head.next;
}

let head = new ListNode(1);
head.next = new ListNode(4);
head.next.next = new ListNode(3);
head.next.next.next = new ListNode(2);
head.next.next.next.next = new ListNode(5);
head.next.next.next.next.next = new ListNode(2);

console.log(solve_partition_list(head, 3));
