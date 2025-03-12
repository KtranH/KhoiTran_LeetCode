"""
Example 1:


Input: root = [4,2,7,1,3], val = 2
Output: [2,1,3]
Example 2:


Input: root = [4,2,7,1,3], val = 5
Output: []
"""

class Node:
    def __init__(self, val):
        self.val = val
        self.left = None
        self.right = None
class TreeNode:
    def __init__(self):
        self.root = None
    def insert(self, val):
        if not self.root:
            self.root = Node(val)
        else:
            self._insert_recursive(self.root,val)
    def _insert_recursive(self, root, val):
        if val < root.val:
            if not root.left:
                root.left = Node(val)
            else:
                self._insert_recursive(root.left, val)
        else:
            if not root.right:
                root.right = Node(val)
            else:
                self._insert_recursive(root.right, val)
    """
    def BST(self, node, val):
        if val < node.val:
            if not node.left:
                return None
            else:
                return self.BST(node.left, val)
        elif val > node.val:
            if not node.right:
                return None
            else:
                return self.BST(node.right, val)
        else:
            return node
    """
    def solve_search_in_a_search_tree(self, val):
        while self.root and self.root.val != val:
            if val < self.root.val:
                self.root = self.root.left
            else:
                self.root = self.root.right
        return self.root

test = TreeNode()
values = [4,2,7,1,3]
for value in values:
    test.insert(value)

print(test.solve_search_in_a_search_tree(2))