/*Example 1:


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
Output: []*/

class Node
{
    constructor(val)
    {
        this.val = val;
        this.left = null;
        this.right = null;
    }
}
class TreeNode
{
    constructor()
    {
        this.root = null;
    }
    insert(val)
    {
        if(this.root == null)
        {
            this.root = new Node(val);
        }
        else
        {
            this._insert_recursive(this.root, val);
        }
    }
    _insert_recursive(node, val)
    {
        if(val < node.val)
        {
            if(!node.left)
            {
                node.left = new Node(val);
            }
            else
            {
                this._insert_recursive(node.left, val);
            }
        }
        else
        {
            if(!node.right)
            {
                node.right = new Node(val);
            }
            else
            {
                this._insert_recursive(node.right, val);
            }
        }
    }
    find_successor(root)
    {
        while(root.left)
        {
            root = root.left;
        }
        return root.val;
    }
    solve_delete_node_in_a_bst(root, val)
    {
        if(root == null)
        {
            return null;
        }
        if(root.val > val)
        {
            root.left = this.solve_delete_node_in_a_bst(root.left, val);
        }
        else if(root.val < val)
        {
            root.right = this.solve_delete_node_in_a_bst(root.right, val);
        }
        else
        {
           if(!root.left)
           {
               return root.right;
           }
           else if(!root.right)
           {
               return root.left;
           }
           else
           {
                let successor = this.find_successor(root.right);
                root.val = successor;
                root.right = this.solve_delete_node_in_a_bst(root.right, successor);
           }
        }
        return root;
    }
}

test = new TreeNode();
values = [5,3,6,2,4,null,7];
for(val of values)
{
    test.insert(val);
}
console.log(test.solve_delete_node_in_a_bst(test.root, 3));