"""
Example 1:


Input: root = [1,2,3,4,5,null,7]
Output: [1,#,2,3,#,4,5,7,#]
Explanation: Given the above binary tree (Figure A), your function should populate each next pointer to point to its next right node, just like in Figure B. The serialized output is in level order as connected by the next pointers, with '#' signifying the end of each level.
Example 2:

Input: root = []
Output: []
"""
class TreeNode:
    def __init__(self, val=0, left=None, right=None, next=None):
        self.val = val
        self.left = left
        self.right = right
        self.next = next
    def insert_level_order(self, values):
        if len(values) == 0:
            return None
        self.val = values[0]
        queue = [self]
        i = 1
        while i < len(values) and len(queue) > 0:
            current = queue.pop(0)
            if values[i] is not None:
                current.left = TreeNode(values[i])
                queue.append(current.left)
            i += 1
            if i < len(values) and values[i] is not None:
                current.right = TreeNode(values[i])
                queue.append(current.right)
            i += 1
        return self
    def solve_populating_next_right_pointers_in_each_node_ii(self, root):
        result = root
        while root != None:
            dummy = TreeNode(0)
            tail = dummy
            curr = root
            while curr != None:
                if curr.left != None:
                    tail.next = curr.left
                    tail = tail.next
                if curr.right != None:
                    tail.next = curr.right
                    tail = tail.next
                curr = curr.next
            root = dummy.next
        return result

test = TreeNode()
root = test.insert_level_order([1,2,3,4,5,6,7])
test.solve_populating_next_right_pointers_in_each_node_ii(root)
