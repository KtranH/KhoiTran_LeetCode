
"""
Input: head = [[7,null],[13,0],[11,4],[10,2],[1,0]]
Output: [[7,null],[13,0],[11,4],[10,2],[1,0]]
"""
class Node:
    def __init__(self, val = 0, next = None, random = None):
        self.val = val
        self.next = next
        self.random = random
    def printList(self):
        temp = self
        while temp:
            print(temp.val)
            temp = temp.next
    def solve_copyRandomList(self, head: 'Node') -> 'Node':
        if not head:
            return None

        curr = head
        while curr:
            copy = Node(curr.val)
            copy.next = curr.next
            curr.next = copy
            curr = copy.next

        curr = head
        while curr:
            if curr.random:
                curr.next.random = curr.random.next
            curr = curr.next.next

        pseudo_head = Node(0)
        copy_curr = pseudo_head
        curr = head

        while curr:
            copy = curr.next
            copy_curr.next = copy
            copy_curr = copy

            curr.next = copy.next
            curr = curr.next

        return pseudo_head.next