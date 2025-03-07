"""
Example 1:


Input: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 1
Output: 3
Explanation: The LCA of nodes 5 and 1 is 3.
Example 2:


Input: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 4
Output: 5
Explanation: The LCA of nodes 5 and 4 is 5, since a node can be a descendant of itself according to the LCA definition.
Example 3:

Input: root = [1,2], p = 1, q = 2
Output: 1
"""

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
        queue = [self.root]
        i = 1
        while queue and i < len(values):
            node = queue.pop(0)
            if values[i] is not None:
                node.left = Node(values[i])
                queue.append(node.left)
            i += 1
            if i < len(values) and values[i] is not None:
                node.right = Node(values[i])
                queue.append(node.right)
            i += 1
        return self.root
    def DFS(self, Node, q, p):
        if Node is None:
            return None
        if Node.val == p or Node.val == q:
            return Node
        left = self.DFS(Node.left, q, p)
        right = self.DFS(Node.right, q, p)
        if left and right:
            return Node
        return left if left else right
    def solve_lowest_common_ancestor_of_a_binary_tree(self, root, p, q):
        return self.DFS(root, q, p).val

test = TreeNode()

root = test.insert_level_order([3,5,1,6,2,0,8,None,None,7,4])

print(test.solve_lowest_common_ancestor_of_a_binary_tree(root, 5, 1)) # 3