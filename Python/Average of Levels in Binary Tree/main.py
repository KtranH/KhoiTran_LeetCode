"""
Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: [3.00000,14.50000,11.00000]
Explanation: The average value of nodes on level 0 is 3, on level 1 is 14.5, and on level 2 is 11.
Hence return [3, 14.5, 11].
Example 2:

Input: root = [3,9,20,15,7]
Output: [3.00000,14.50000,11.00000]
Explanation: The average value of nodes on level 0 is 3, on level 1 is 14.5, and on level 2 is 11.
Hence return [3, 14.5, 11].
"""

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
    def insert_bfs_tree(self, data):
        if not data:
            return None
        self.val = data[0]
        queue = [self]
        i = 1
        while queue:
            node = queue.pop(0)
            if i < len(data) and data[i] is not None:
                node.left = TreeNode(data[i])
                queue.append(node.left)
            i += 1
            if i < len(data) and data[i] is not None:
                node.right = TreeNode(data[i])
                queue.append(node.right)
            i += 1
        return self

    def solve_average_of_levels_in_binary_tree(self, root):
        if not root:
            return []
        queue = [root]
        result = []
        while queue:
            level_size = len(queue)
            level_sum = 0
            for i in range(level_size):
                node = queue.pop(0)
                level_sum += node.val
                if node.left:
                    queue.append(node.left)
                if node.right:
                    queue.append(node.right)
            result.append(level_sum / level_size)
        return result

test = TreeNode()
test.insert_bfs_tree([3,9,20,None,None,15,7])
print(test.solve_average_of_levels_in_binary_tree(test))