"""
Example 1:

Input: root = [3,1,4,null,2], k = 1
Output: 1
Example 2:

Input: root = [5,3,6,2,4,null,null,1], k = 3
Output: 3
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
    def solve_kth_smallest_element_in_a_bst(self, root, k):
        if root is None:
            return None
        stack = []
        while root is not None or len(stack) > 0:
            while root is not None:
                stack.append(root)
                root = root.left
            root = stack.pop()
            k -= 1
            if k == 0:
                return root.val
            root = root.right
        return None