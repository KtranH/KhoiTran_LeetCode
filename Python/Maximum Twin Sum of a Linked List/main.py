"""
Example 1:


Input: head = [5,4,2,1]
Output: 6
Explanation:
Nodes 0 and 1 are the twins of nodes 3 and 2, respectively. All have twin sum = 6.
There are no other nodes with twins in the linked list.
Thus, the maximum twin sum of the linked list is 6. 
Example 2:


Input: head = [4,2,2,3]
Output: 7
Explanation:
The nodes with twins present in this linked list are:
- Node 0 is the twin of node 3 having a twin sum of 4 + 3 = 7.
- Node 1 is the twin of node 2 having a twin sum of 2 + 2 = 4.
Thus, the maximum twin sum of the linked list is max(7, 4) = 7. 
Example 3:


Input: head = [1,100000]
Output: 100001
Explanation:
There is only one node with a twin in the linked list having twin sum of 1 + 100000 = 100001.
"""
class Node:
    def __init__(self, val):
        self.val = val
        self.next = None
class ListNode:
    def __init__(self):
        self.head = None
    def append(self, val):
        if self.head is None:
            self.head = Node(val)
            return
        current = self.head
        while current.next:
            current = current.next
        current.next = Node(val)
    def display(self):
        current = self.head
        while current:
            print(current.val, end = ' ')
            current = current.next
        print()
    def reverse(self, slow_node):
        prev = None
        current = slow_node
        while current:
            next_node = current.next
            current.next = prev
            prev = current
            current = next_node
        slow_node = prev
        return slow_node
    def find_middle(self):
        slow = self.head
        fast = self.head
        while fast and fast.next:
            slow = slow.next
            fast = fast.next.next
        return slow
    def solve_maximum_twin_sum_of_a_linked_list(self):
        slow_node = self.find_middle()
        slow_node = self.reverse(slow_node)
        current = self.head
        max_sum = 0
        while slow_node:
            temp_sum = current.val + slow_node.val
            if temp_sum > max_sum:
                max_sum = temp_sum
            current = current.next
            slow_node = slow_node.next
        return max_sum
    
# Test
linked_list = ListNode()
linked_list.append(5)
linked_list.append(4)
linked_list.append(2)
linked_list.append(1)
print(linked_list.solve_maximum_twin_sum_of_a_linked_list())