"""
Example 1:

Input: inorder = [9,3,15,20,7], postorder = [9,15,7,20,3]
Output: [3,9,20,null,null,15,7]
Example 2:

Input: inorder = [-1], postorder = [-1]
Output: [-1]
 
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
    def solve_construct_binary_tree_from_inorder_and_postorder_traversal(self, inorder, postorder):
        if not inorder or not postorder:
            return None
        root = TreeNode(postorder[-1])
        i = inorder.index(postorder[-1])
        root.left = self.solve_construct_binary_tree_from_inorder_and_postorder_traversal(inorder[:i], postorder[:i])
        root.right = self.solve_construct_binary_tree_from_inorder_and_postorder_traversal(inorder[i+1:], postorder[i:-1])
        return root

test = TreeNode()
root = test.insert_level_order([3,9,20,15,7])
test.solve_construct_binary_tree_from_inorder_and_postorder_traversal(root, [9,3,15,20,7])
