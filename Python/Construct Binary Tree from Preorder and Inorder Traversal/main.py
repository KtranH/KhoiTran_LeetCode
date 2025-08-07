"""
Example 1:


Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
Output: [3,9,20,null,null,15,7]
Example 2:

Input: preorder = [-1], inorder = [-1]
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
    def solve_construct_binary_tree_from_preorder_and_inorder_traversal(self, preorder, inorder):
        if not preorder or not inorder:
            return None
        root = TreeNode(preorder[0])
        i = inorder.index(preorder[0]) 
        root.left = self.solve_construct_binary_tree_from_preorder_and_inorder_traversal(preorder[1:i+1], inorder[:i])
        root.right = self.solve_construct_binary_tree_from_preorder_and_inorder_traversal(preorder[i+1:], inorder[i+1:])
        return root

root = TreeNode().insert_level_order([3,9,20,15,7])
print(root.solve_construct_binary_tree_from_preorder_and_inorder_traversal([3,9,20,15,7], [9,3,15,20,7]))