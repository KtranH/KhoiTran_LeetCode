"""
Example 1:

Input: root = [1,2,3]
Output: 25
Explanation:
The root-to-leaf paths are:
1 -> 2: 12
1 -> 3: 13
Therefore, sum = 12 + 13 = 25.

Example 2:

Input: root = [4,9,0,5,1]
Output: 1026
Explanation:
The root-to-leaf paths are:
4 -> 9 -> 5: 495
4 -> 9 -> 1: 491
4 -> 0: 40
Therefore, sum = 495 + 491 + 40 = 1026.
"""

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
    def insert_level_order(self, values):
        if not values:
            return None
        self.val = values[0]
        queue = [self]
        i = 1
        while i < len(values) and queue:
            current = queue.pop(0)
            if values[i] is not None:
                current.left = TreeNode(values[i])
                queue.append(current.left)
            i += 1
            if i < len(values) and values[i] is not None:
                current.right = TreeNode(values[i])
                queue.append(current.right)
            i += 1
        return self
    def solve_sum_root_to_leaf(self, root):
        def DFS(root, curr_sum):
            if not root:
                return 0
            curr_sum = curr_sum * 10 + root.val
            if not root.left and not root.right:
                return curr_sum
            return DFS(root.left, curr_sum) + DFS(root.right, curr_sum)
        return DFS(root, 0)
        
test = TreeNode().insert_level_order([1,2,3])
print(test.solve_sum_root_to_leaf(test))
        