"""
Example 1:


Input: root = [4,2,7,1,3,6,9]
Output: [4,7,2,9,6,3,1]
Example 2:


Input: root = [2,1,3]
Output: [2,3,1]
Example 3:

Input: root = []
Output: []
"""

class TreeNode:
    def __init__(self):
        self.root = None
    def insert_level_order(self, data):
        if not data:
            return None
        self.root = TreeNode(data[0])
        queue = [self.root]
        i = 1
        while queue:
            node = queue.pop(0)
            if i < len(data) and data[i]:
                node.left = TreeNode(data[i])
                queue.append(node.left)
            i += 1
            if i < len(data) and data[i]:
                node.right = TreeNode(data[i])
                queue.append(node.right)
            i += 1
        return self.root
    def solve_invertTree(self, root: TreeNode) -> TreeNode:
        if root is None:
            return None
        root.left, root.right = root.right, root.left
        self.solve_invertTree(root.left)
        self.solve_invertTree(root.right)
        return root

test = TreeNode()
root = test.insert_level_order([4,2,7,1,3,6,9])
test.solve_invertTree(root)
print(root)