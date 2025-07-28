/*
Example 1:


Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]
Example 2:

Input: head = [1], n = 1
Output: []
Example 3:

Input: head = [1,2], n = 1
Output: [1]
*/

function ListNode(val, next) {
    this.val = (val === undefined ? 0 : val);
    this.next = (next === undefined ? null : next);
}

function removeNthFromEnd(head, n) {
    if (!head || n <= 0) {
        return head;
    }
    
    let dummy = new ListNode(0);
    dummy.next = head;
    
    let first = dummy;
    let second = dummy;
    
    for (let i = 0; i < n; i++) {
        first = first.next;
    }
    
    while (first.next) {
        first = first.next;
        second = second.next;
    }
    
    second.next = second.next.next;
    
    return dummy.next;
}

let head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(3);
head.next.next.next = new ListNode(4);
head.next.next.next.next = new ListNode(5);

let n = 2;

let result = removeNthFromEnd(head, n);

while (result) {
    console.log(result.val);
    result = result.next;
}
