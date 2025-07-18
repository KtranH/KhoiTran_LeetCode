"""
Example 1:


Input: head = [3,2,0,-4], pos = 1
Output: true
Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).
Example 2:


Input: head = [1,2], pos = 0
Output: true
Explanation: There is a cycle in the linked list, where the tail connects to the 0th node.
Example 3:


Input: head = [1], pos = -1
Output: false
Explanation: There is no cycle in the linked list.
"""

# Tạo nút
class Node:
    # Khởi tạo nút
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
class LinkedList:
    # Khởi tạo danh sách
    def __init__(self):
        self.head = None
    # Thêm phần tử vào cuối danh sách
    def append(self, val):
        if not self.head:
            self.head = Node(val)
            return
        current = self.head
        while current.next:
            current = current.next
        current.next = Node(val)
    # In ra danh sách
    def print_list(self):
        current = self.head
        while current:
            print(current.val)
            current = current.next
    # Kiểm tra xem danh sách có chứa chu kỳ không
    def has_cycle(self):
        slow = self.head
        fast = self.head
        while fast and fast.next:
            slow = slow.next
            fast = fast.next.next
            if slow == fast:
                return True
        return False
       
    