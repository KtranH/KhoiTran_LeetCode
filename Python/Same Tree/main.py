"""
Example 1:

Input: p = [1,2], q = [1,None,2]
Output: false
Example 2:

Input: p = [1,2,1], q = [1,1,2]
Output: false
"""

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
    def insert_level_order(self, data):
        if not data:
            return None
        self.root = TreeNode(data[0])
        queue = [self.root]
        i = 1
        while queue:
            node = queue.pop(0)
            if i < len(data) and data[i]:
                node.left = TreeNode(data[i])
                queue.append(node.left)
            i += 1
            if i < len(data) and data[i]:
                node.right = TreeNode(data[i])
                queue.append(node.right)
            i += 1
        return self.root
    
def solve_isSameTree(p: TreeNode, q: TreeNode) -> bool:
    if p is None and q is None:
        return True
    if p is None or q is None:
        return False
    if p.val != q.val:
        return False
    return solve_isSameTree(p.left, q.left) and solve_isSameTree(p.right, q.right)

test = TreeNode()
root = test.insert_level_order([1,2])
root2 = test.insert_level_order([1,None,2])
print(solve_isSameTree(root, root2))

