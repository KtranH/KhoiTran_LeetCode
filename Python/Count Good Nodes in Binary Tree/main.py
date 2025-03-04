"""
Example 1:



Input: root = [3,1,4,3,null,1,5]
Output: 4
Explanation: Nodes in blue are good.
Root Node (3) is always a good node.
Node 4 -> (3,4) is the maximum value in the path starting from the root.
Node 5 -> (3,4,5) is the maximum value in the path
Node 3 -> (3,1,3) is the maximum value in the path.
Example 2:



Input: root = [3,3,null,4,2]
Output: 3
Explanation: Node 2 -> (3, 3, 2) is not good, because "3" is higher than it.
Example 3:

Input: root = [1]
Output: 1
Explanation: Root is considered as good.
"""
class Node:
    def __init__(self, data):
        self.val = data
        self.left = None
        self.right = None
class TreeNode:
    def __init__(self):
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
    def DFS(self, root, max_val):
        if root is None:
            return 0
        if root.val >= max_val:
            count = 1
            max_val = root.val
        else:
            count = 0
        return count + self.DFS(root.left, max_val) + self.DFS(root.right, max_val)
    def solve_count_good_nodes_in_binary_tree(self, root):
        return self.DFS(root, root.val)
    
test = TreeNode()
root = test.insert_level_order([3,1,4,3,None,1,5])
print(test.solve_count_good_nodes_in_binary_tree(root)) # 4