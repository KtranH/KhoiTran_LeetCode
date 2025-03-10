"""
Example 1:


Input: root = [1,null,1,1,1,null,null,1,1,null,1,null,null,null,1]
Output: 3
Explanation: Longest ZigZag path in blue nodes (right -> left -> right).
Example 2:


Input: root = [1,1,1,null,1,null,null,1,1,null,1]
Output: 4
Explanation: Longest ZigZag path in blue nodes (left -> right -> left -> right).
Example 3:

Input: root = [1]
Output: 0
"""

class Node:
    def __init__(self, data):
        self.val = data
        self.left = None
        self.right = None
class TreeNode:
    def __init__(self):
        self.root = None
        self.max_length = 0
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
    def DFS(self, root, length, direction):
        if root is None:
            return 
        if length > self.max_length:
            self.max_length = length
        if direction == "left":
            self.DFS(root.left, length + 1, "left")
            self.DFS(root.right, 1, "left")
        else:
            self.DFS(root.left, 1, "right")
            self.DFS(root.right, length + 1, "left")
    def solve_longest_zigzag_path_in_a_binary_tree(self, root):
        self.DFS(root, 0, "left")
        self.DFS(root, 0, "right")
        return self.max_length
    
test = TreeNode()

root = test.insert_level_order([1,None,1,1,1,None,None,1,1,None,1,None,None,None,1])

print(test.solve_longest_zigzag_path_in_a_binary_tree(root)) # 3
        