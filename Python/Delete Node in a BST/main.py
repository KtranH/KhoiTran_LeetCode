"""
Example 1:


Input: root = [5,3,6,2,4,null,7], key = 3
Output: [5,4,6,2,null,null,7]
Explanation: Given key to delete is 3. So we find the node with value 3 and delete it.
One valid answer is [5,4,6,2,null,null,7], shown in the above BST.
Please notice that another valid answer is [5,2,6,null,4,null,7] and it's also accepted.

Example 2:

Input: root = [5,3,6,2,4,null,7], key = 0
Output: [5,3,6,2,4,null,7]
Explanation: The tree does not contain a node with value = 0.
Example 3:

Input: root = [], key = 0
Output: []"
"""
class Node:
    def __init__(self, val):
        self.val = val
        self.right = None
        self.left = None
class TreeNode:
    def __init__(self):
        self.root = None
        self.successor = None
    def insert(self, val):
        if not self.root:
            self.root = Node(val)
        else:
            self._insert_recursive(self.root, val)
    def _insert_recursive(self, root, val):
        if val < root.val:
            if not root.left:
                root.left = Node(val)
            else:
                self._insert_recursive(root.left, val)
        else:
            if not root.right:
                root.right = Node(val)
            else:
                self._insert_recursive(root.right, val)
    def find_successor(self, root):
        while root.left:
            root = root.left
        return root.val
    def solved_delete_node_in_a_bst(self, root, key):
        if root is None:
            return None
        if key < root.val:
            root.left = self.solved_delete_node_in_a_bst(root.left, key)
        elif key > root.val:
            root.right = self.solved_delete_node_in_a_bst(root.right, key)
        else:
            if not root.left:
                return root.right
            elif not root.right:
                return root.left
            else:
                self.successor = self.find_successor(root.right)
                root.val = self.successor
                root.right = self.solved_delete_node_in_a_bst(root.right, self.successor)
        return root
    
test = TreeNode()
values = [5,3,6,2,4,None,7]
for val in values:
    test.insert(val)

print(test.solved_delete_node_in_a_bst(test.root, 3).val) # 4
        