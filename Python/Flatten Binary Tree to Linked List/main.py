"""
Example 1:


Input: root = [1,2,5,3,4,null,6]
Output: [1,null,2,null,3,null,4,null,5,null,6]
Example 2:

Input: root = []
Output: []
Example 3:

Input: root = [0]
Output: [0]
"""

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
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
    def DFS(self, root, prev):
        if root is None:
            return None
        self.DFS(root.right, prev)
        self.DFS(root.left, prev)
        root.right = prev
        root.left = None
        prev = root
    def solve_flatten_binary_tree_to_linked_list(self, root):
        if not root:
            return None
        prev = None
        self.DFS(root, prev)
        return root

test = TreeNode()
test.insert_level_order([1,2,5,3,4,None,6])
test.solve_flatten_binary_tree_to_linked_list(test)
print(test)