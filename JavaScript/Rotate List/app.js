/*
Example 1:

Input: head = [1,2,3,4,5], k = 2
Output: [4,5,1,2,3]
Example 2:

Input: head = [0,1,2], k = 4
Output: [2,0,1]
*/

function ListNode(val, next) {
    this.val = (val===undefined ? 0 : val)
    this.next = (next===undefined ? null : next)
}

function solve_rotate_list(head, k) {
    if(head == null || head.next == null || k == 0) {
        return head;
    }
    
    let length = 1;
    let tail = head;
    while(tail.next != null) {
        length++;
        tail = tail.next;
    }
    
    k = k % length;
    if(k == 0) {
        return head;
    }
    
    let stepsToNewHead = length - k;
    let prev = null;
    let current = head;
    for(let i = 0; i < stepsToNewHead; i++) {
        prev = current;
        current = current.next;
    }
    
    prev.next = null;
    tail.next = head;
    head = current;
    
    return head;
}