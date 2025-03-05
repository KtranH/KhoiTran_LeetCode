"""
Example 1:


Input: root = [10,5,-3,3,2,null,11,3,-2,null,1], targetSum = 8
Output: 3
Explanation: The paths that sum to 8 are shown.
Example 2:

Input: root = [5,4,8,11,null,13,4,7,2,null,null,5,1], targetSum = 22
Output: 3
"""
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
    def dfs(self, root, hashmap_sum, currentSum, targetSum):
        if root is None:
            return 0
        else:
             currentSum += root.val
             count = hashmap_sum.get(currentSum - targetSum, 0)
        hashmap_sum[currentSum] = hashmap_sum.get(currentSum, 0) + 1
        count += self.dfs(root.left, hashmap_sum, currentSum, targetSum)
        count += self.dfs(root.right, hashmap_sum, currentSum, targetSum)
        hashmap_sum[currentSum] -= 1
        return count

    def solve_path_sum_iii(self, root, targetSum = 8):
        hashmap_sum = {0: 1}
        return self.dfs(root, hashmap_sum, 0, targetSum)

tree = TreeNode()
root = tree.insert_level_order([5,4,8,11,None,13,4,7,2,None,None,5,1])
print(tree.solve_path_sum_iii(root, 22)) # 3