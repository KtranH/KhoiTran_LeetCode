"""
Example 1:

Input: root = [1,2,3,null,5,null,4]

Output: [1,3,4]

Explanation:



Example 2:

Input: root = [1,2,3,4,null,null,null,5]

Output: [1,3,4,5]

Explanation:



Example 3:

Input: root = [1,null,3]

Output: [1,3]

Example 4:

Input: root = []

Output: []
"""

class Node:
    def __init__(self, data):
        self.val = data
        self.left = None
        self.right = None
class TreeNode:
    def __init__(self, ):
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
    def solve_binary_tree_right_side_view(self, root):
        if(root is None):
            return []
        queue = [root]
        result = []
        while queue:
            level_size = len(queue)
            for i in range(level_size):
                node = queue.pop(0)
                if(i == level_size - 1):
                    result.append(node.val)
                if(node.left):
                    queue.append(node.left)
                if(node.right):
                    queue.append(node.right)
        return result

test = TreeNode()
root = test.insert_level_order([1,2,3,None,5,None,4])
print(test.solve_binary_tree_right_side_view(root))