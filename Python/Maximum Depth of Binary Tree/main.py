"""
Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: 3
Example 2:

Input: root = [1,null,2]
Output: 2
"""

from collections import deque
class Node:
    def __init__(self, val):
        self.val = val
        self.left = None
        self.right = None
class TreeNode:
    def __init__(self):
        self.root = None     
    def insert_level_order(self, values):
        if not values:
            return None
        self.root = Node(values[0])
        queue = deque([self.root])
        i = 1
        while queue and i < len(values):
            node = queue.popleft()
            if values[i] is not None:
                node.left = Node(values[i])
                queue.append(node.left)
            i += 1
            if i < len(values) and values[i] is not None:
                node.right = Node(values[i])
                queue.append(node.right)
            i += 1
        return self.root
    def solve_maximum_depth_of_binary_tree(self, node):
        if node is None:
            return 0
        left_height = self.solve_maximum_depth_of_binary_tree(node.left)
        right_height = self.solve_maximum_depth_of_binary_tree(node.right)
        return max(left_height, right_height) + 1
    
test = TreeNode()
root = test.insert_level_order([3,9,20,None,None,15,7])
print(test.solve_maximum_depth_of_binary_tree(root))