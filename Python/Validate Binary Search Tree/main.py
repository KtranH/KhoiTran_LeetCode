"""
Example 1:

Input: root = [2,1,3]
Output: true
Example 2:

Input: root = [5,1,4,null,3,6]
Output: false
"""

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
    def solve_validate_binary_search_tree(self, root):
        if root is None:
            return True
        stack = []
        prev = None
        while root is not None or len(stack) > 0:
            while root is not None:
                stack.append(root)
                root = root.left
            root = stack.pop()
            if prev is not None and root.val <= prev.val:
                return False
            prev = root
            root = root.right
        return True
