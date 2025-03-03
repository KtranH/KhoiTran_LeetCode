"""
Example 1:


Input: root1 = [3,5,1,6,2,9,8,null,null,7,4], root2 = [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]
Output: true
Example 2:


Input: root1 = [1,2,3], root2 = [1,3,2]
Output: false
"""

from collections import deque
class Node:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None
class TreeNode:
    def __init__(self):
        self.root = None
    def insert_level_order(self, value):
        if not value:
            return None
        self.root = Node(value[0])
        queue = deque([self.root])
        i = 1
        while queue and i < len(queue):
            current = queue.popleft()
            if value[i] is not None:
                current.left = Node(value[i])
                queue.append(current.left)
            i += 1
            if i < len(value) and value[i] is not None:
                current.right = Node(value[i])
                queue.append(current.right)
            i += 1
        return self.root
    def dfs(self, root):
        if root is None:
            return []
        if root.left is None and root.right is None:
            return [root.value]
        return self.dfs(root.left) + self.dfs(root.right)
      
    def solve_leaf_similar_trees(self, root1, root2):
        if root1.value != root2.value:
            return False
        return self.dfs(root1) == self.dfs(root2)
        
    
test = TreeNode()
root1 = test.insert_level_order([3,5,1,6,2,9,8,None,None,7,4])
root2 = test.insert_level_order([3,5,1,6,7,4,2,None,None,None,None,None,None,9,8])
print(test.solve_leaf_similar_trees(root1, root2), root1.value, root2.value)

            