"""
Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: [[3],[9,20],[15,7]]
Example 2:

Input: root = [1]
Output: [[1]]
Example 3:

Input: root = []
Output: []
"""

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
    def insert_bfs_tree(self, data):
        if not data:
            return None
        self.val = data.pop(0)
        queue = [self]
        while queue:
            node = queue.pop(0)
            if data:
                node.left = TreeNode(data.pop(0))
                queue.append(node.left)
            if data:
                node.right = TreeNode(data.pop(0))
                queue.append(node.right)
        return self
    def solve_binary_tree_level_order_traversal(self, root):
        if not root:
            return []
        queue = [root]
        result = []
        while queue:
            level_size = len(queue)
            level_order = []
            for i in range(level_size):
                node = queue.pop(0)
                level_order.append(node.val)
                if node.left:
                    queue.append(node.left)
                if node.right:
                    queue.append(node.right)
            result.append(level_order)
        return result

test = TreeNode()
test.insert_bfs_tree([3,9,20,None,None,15,7])
print(test.solve_binary_tree_level_order_traversal(test))