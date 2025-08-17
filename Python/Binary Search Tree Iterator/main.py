"""
Example 1:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]

Example 2:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]

Example 3:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]

Example 4:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]

Example 5:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]
"""

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
        self.stack = []
        self._push_left(self)
    def insert_level_order(self, values):
        if not values:
            return None
        self.val = values[0]
        queue = [self]
        i = 1
        while i < len(values) and queue:
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
    def _push_left(self, node):
        while node:
            self.stack.append(node)
            node = node.left
    def next(self):
        node = self.stack.pop()
        self._push_left(node.right)
        return node.val
    def hasNext(self):
        return len(self.stack) > 0
        
        
