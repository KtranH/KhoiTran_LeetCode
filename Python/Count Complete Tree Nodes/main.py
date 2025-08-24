"""
Example 1:


Input: root = [1,2,3,4,5,6]
Output: 6
Example 2:

Input: root = []
Output: 0
Example 3:

Input: root = [1]
Output: 1
"""

class TreeNode:
    def __init__(self):
        self.root = None
    def insert_level_order(self, data):
        if not data:
            return None
        self.root = Node(data[0])
        queue = [self.root]
        i = 1
        while queue:
            node = queue.pop(0)
            if i < len(data) and data[i]:
                node.left = Node(data[i])
                queue.append(node.left)
            i += 1
            if i < len(data) and data[i]:
                node.right = Node(data[i])
                queue.append(node.right)
            i += 1
        return self.root
    def solve_count_complete_tree_nodes(self, root):
        if not root:
            return 0
        return 1 + self.solve_count_complete_tree_nodes(root.left) + self.solve_count_complete_tree_nodes(root.right)

test = TreeNode()
test.insert_level_order([1,2,3,4,5,6])
print(test.solve_count_complete_tree_nodes(test.root))