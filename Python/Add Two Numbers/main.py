l1 = [2,4,3]
l2 = [5,6,4]


"""
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
"""

class Node:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
class LinkedList:
    def __init__(self):
        self.head = None
    def append(self, val):
        if not self.head:
            self.head = Node(val)
            return
        current = self.head
        while current.next:
            current = current.next
        current.next = Node(val)
    def print_list(self):
        current = self.head
        while current:
            print(current.val)
            current = current.next
    def add_two_numbers(self, l1, l2):
        Sum = LinkedList()
        carry = 0

        while l1 or l2:
            val1 = l1.val if l1 else 0
            val2 = l2.val if l2 else 0

            total = val1 + val2 + carry
            Sum.append(total % 10)
            carry = total // 10

            l1 = l1.next if l1 else None
            l2 = l2.next if l2 else None

        if carry:
            Sum.append(carry)

        return Sum


ll = LinkedList()
ll.append(2)
ll.append(4)
ll.append(3)
ll.print_list()
