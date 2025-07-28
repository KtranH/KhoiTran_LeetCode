"""
Example 1:

Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]
Example 2:

Input: head = [1], n = 1
Output: []
Example 3:

Input: head = [1,2], n = 1
Output: [1]
"""

class ListNode:
    def __init__(self, val = 0, next = None):
        self.val = val
        self.next = next
    def solve_remove_nth_node_from_end_of_list(self, head, n):
        if not head or n <= 0:
            return head
        
        dummy = ListNode(0)
        dummy.next = head
        first = dummy
        second = dummy
        
        for _ in range(n):
            first = first.next
            
        while first.next:
            first = first.next
            second = second.next
        
        # remove node
        second.next = second.next.next
        return dummy.next

head = [1,2,3,4,5]
n = 2
print(ListNode().solve_remove_nth_node_from_end_of_list(head, n))
