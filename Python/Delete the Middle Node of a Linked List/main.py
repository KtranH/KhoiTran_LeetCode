"""
Example 1:


Input: head = [1,3,4,7,1,2,6]
Output: [1,3,4,1,2,6]
Explanation:
The above figure represents the given linked list. The indices of the nodes are written below.
Since n = 7, node 3 with value 7 is the middle node, which is marked in red.
We return the new list after removing this node. 
Example 2:


Input: head = [1,2,3,4]
Output: [1,2,4]
Explanation:
The above figure represents the given linked list.
For n = 4, node 2 with value 3 is the middle node, which is marked in red.
Example 3:


Input: head = [2,1]
Output: [2]
Explanation:
The above figure represents the given linked list.
For n = 2, node 1 with value 1 is the middle node, which is marked in red.
Node 0 with value 2 is the only node remaining after removing node 1.
"""

class ListNode:
    def __init__(self, val):
        self.val = val
        self.next = None
class LinkedListNode:
    def __init__(self):
        self.head = None
    def append(self, data):
        new_node = ListNode(data)
        if self.head is None:
            self.head = new_node
            return
        last_node = self.head
        while last_node.next:
            last_node = last_node.next
        last_node.next = new_node
    def print_list(self):
        temp = self.head
        while temp:
            print(temp.val)
            temp = temp.next
    def count_list(self):
        count = 0
        current_node = self.head
        while current_node:
            count += 1
            current_node = current_node.next
        return count
    def solve_delete_the_middle_node_of_a_linked_list(self):
        count = self.count_list()
        if count == 0 or count == 1:
            self.head = None
            return
        
        mid = count // 2
        current_node = self.head

        if mid == 0:
            self.head = self.head.next
            return
        for i in range(mid - 1):
            current_node = current_node.next
        current_node.next = current_node.next.next

ll = LinkedListNode()
ll.append(1)
ll.append(2)
ll.append(3)
ll.append(4)
ll.append(5)

ll.solve_delete_the_middle_node_of_a_linked_list()
ll.print_list()