"""
Example 1:


Input: root = [1,7,0,7,-8,null,null]
Output: 2
Explanation: 
Level 1 sum = 1.
Level 2 sum = 7 + 0 = 7.
Level 3 sum = 7 + -8 = -1.
So we return the level with the maximum sum which is level 2.
Example 2:

Input: root = [989,null,10250,98693,-89388,null,null,null,-32127]
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
    def insert_level_order(self, val):
        if not val:
            return None
        self.root = Node(val[0])
        queue = [self.root]
        i = 1
        while queue and i < len(val):
            node = queue.pop(0)
            if val[i] is not None:
                node.left = Node(val[i])
                queue.append(node.left)
            i += 1
            if i < len(val) and val[i] is not None:
                node.right = Node(val[i])
                queue.append(node.right)
            i += 1
        return self.root
    def solve_maximum_level_sum(self, root):
        if not root:
            return 0
        
        max_sum = float('-inf')
        max_level_tree = level_tree = 0
        queue = deque([root])
        
        while queue:
            level_size = len(queue)
            level_sum = sum(node.val for node in queue)
            level_tree += 1
            
            if level_sum > max_sum:
                max_sum = level_sum
                max_level_tree = level_tree
            
            for _ in range(level_size):
                node = queue.popleft()
                if node.left:
                    queue.append(node.left)
                if node.right:
                    queue.append(node.right)
        
        return max_level_tree

test = TreeNode()
root = test.insert_level_order([-100,-200,-300,-20,-5,-10,None])
print(test.solve_maximum_level_sum(root))