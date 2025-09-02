"""
Example 1:

Input: root = [4,2,6,1,3]
Output: 1
Example 2:

Input: root = [1,0,48,null,null,12,49]
Output: 1
"""

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
    def insert_bfs_tree(self, data):
        if len(data) == 0:
            return
        self.val = data[0]
        queue = []
        queue.append(self)
        i = 1
        while len(queue) > 0:
            node = queue.pop(0)
            if i < len(data) and data[i] is not None:
                node.left = TreeNode(data[i])
                queue.append(node.left)
            i += 1
            if i < len(data) and data[i] is not None:
                node.right = TreeNode(data[i])
                queue.append(node.right)
            i += 1
        return self
    def solve_minimum_absolute_difference_in_bst(root):
        if root is None:
            return []
        stack = []
        prev = None
        result = float('inf')
        while root or stack:
            while root:
                stack.append(root)
                root = root.left
            node = stack.pop()
            if prev:
                result = min(result, node.val - prev.val)
            prev = node
            root = node.right
        return result

root = TreeNode()
root.insert_bfs_tree([4,2,6,1,3])
print(root.solve_minimum_absolute_difference_in_bst())
