"""
Example 1:

Input: root = [5,4,8,11,None,13,4,7,2,None,None,None,1], targetSum = 22
Output: true
Explanation: The root-to-leaf path with the target sum is shown.
Example 2:

Input: root = [1,2,3], targetSum = 5
Output: false
Explanation: There two root-to-leaf paths in the tree:
(1 --> 2): The sum is 3.
(1 --> 3): The sum is 4.
There is no root-to-leaf path with sum = 5.
Example 3:

Input: root = [], targetSum = 0
Output: false
Explanation: Since the tree is empty, there are no root-to-leaf paths.
"""

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
    def insert_level_order(self, values):
        if len(values) == 0:
            return None
        self.val = values[0]
        queue = [self]
        i = 1
        while i < len(values) and len(queue) > 0:
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
    def solve_path_sum(self, root, target_sum):
        if root is None:
            return False
        if root.left is None and root.right is None and root.val == target_sum:
            return True
        return self.solve_path_sum(root.left, target_sum - root.val) or self.solve_path_sum(root.right, target_sum - root.val)

root = TreeNode()
root.insert_level_order([5,4,8,11,None,13,4,7,2,None,None,None,1])
print(root.solve_path_sum(root, 22))