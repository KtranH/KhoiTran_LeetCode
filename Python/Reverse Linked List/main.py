"""
Example 1:


Input: head = [1,2,3,4,5]
Output: [5,4,3,2,1]
Example 2:


Input: head = [1,2]
Output: [2,1]
Example 3:

Input: head = []
Output: []
"""
class Node:
    def __init__(self, val):
        self.val = val
        self.next = None
class ListNode:
    def __init__(self):
        self.head = None
    def append(self, data):
        new_node = Node(data)
        if self.head is None:
            self.head = new_node
            return
        last = self.head
        while last.next:
            last = last.next
        last.next = new_node
    def print_list(self):
        cur = self.head
        while cur:
            print(cur.val, end=' ')
            cur = cur.next
        print()
    def reserve(self):
        prev = None
        cur = self.head
        while cur:
            next_node = cur.next
            cur.next = prev
            prev = cur
            cur = next_node
        self.head = prev

test = ListNode()
test.append(1)
test.append(2)
test.append(3)
test.reserve()
test.print_list()