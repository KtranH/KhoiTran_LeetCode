"""
Example 1:


Input: head = [1,2,3,4,5], k = 2
Output: [4,5,1,2,3]
Example 2:


Input: head = [0,1,2], k = 4
Output: [2,0,1]
"""

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
    def solve_rotate_list(self, head, k):
        if not head or not head.next or k == 0:
            return head

        length = 1
        tail = head
        while tail.next:
            length += 1
            tail = tail.next

        k = k % length
        if k == 0:
            return head
        
        steps_to_new_head = length - k
        prev = None
        current = head
        for _ in range(steps_to_new_head):
            prev = current
            current = current.next

        prev.next = None       
        tail.next = head       
        head = current         

        return head

head = [1,2,3,4,5]
k = 2
print(ListNode().solve_rotate_list(head, k))