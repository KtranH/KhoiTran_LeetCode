/*

Example 1:

Input: head = [1,2,3,4,5], left = 2, right = 4
Output: [1,4,3,2,5]

Example 2:

Input: head = [5], left = 1, right = 1
Output: [5]

*/

function ListNode(val, next)
{
    this.val = (val === undefined ? 0 : val);
    this.next = (next === undefined ? null : next);
}

function solve_reverse_linked_list_ii(head, left, right)
{
    if (head == null || left == right)
    {
        return head;
    }

    let dummy = new ListNode(0);
    dummy.next = head;
    let prev = dummy;

    for (let i = 1; i < left; i++)
    {
        prev = prev.next;
    }

    let curr = prev.next;
    let reverse = null;

    for (let i = 0; i < right - left + 1; i++)
    {
        let next_node = curr.next;
        curr.next = reverse;
        reverse = curr;
        curr = next_node;
    }

    prev.next.next = curr;
    prev.next = reverse;
    return dummy.next;
}

let head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(3);
head.next.next.next = new ListNode(4);
head.next.next.next.next = new ListNode(5);

let left = 2;
let right = 4;

let result = solve_reverse_linked_list_ii(head, left, right);

while (result != null)
{
    console.log(result.val);
    result = result.next;
}
