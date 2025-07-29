"""
Example 1:

Input: head = [1,2,3,3,4,4,5]
Output: [1,2,5]
Example 2:

Input: head = [1,1,1,2,3]
Output: [2,3]
"""

class ListNode:
    def __init__(self, val = 0, next = None):
        self.val = val
        self.next = next
    def solve_remove_duplicates_from_sorted_list_ii(self, head):
        if not head:
            return None
        dummy = ListNode(0)
        dummy.next = head
        prev = dummy
        while prev.next and prev.next.next:
            if prev.next.val == prev.next.next.val:
                dup_val = prev.next.val
                while prev.next and prev.next.val == dup_val:
                    prev.next = prev.next.next
            else:
                prev = prev.next
        return dummy.next

head = [1,2,3,3,4,4,5]
print(ListNode().solve_remove_duplicates_from_sorted_list_ii(head))
