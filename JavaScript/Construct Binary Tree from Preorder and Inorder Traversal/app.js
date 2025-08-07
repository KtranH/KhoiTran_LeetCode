/*
Example 1:

Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
Output: [3,9,20,null,null,15,7]
Example 2:

Input: preorder = [-1], inorder = [-1]
Output: [-1]

*/
class TreeNode
{
    constructor(val)
    {
        this.val = val;
        this.left = null;
        this.right = null;
    }
    insert_level_order(values)
    {
        if(values.length === 0)
            return null;
        this.root = new TreeNode(values[0]);
        let queue = [this.root];
        let i = 1;
        while(i < values.length && queue.length > 0)
        {
            let current = queue.shift();
            if(values[i] !== null)
            {
                current.left = new TreeNode(values[i]);
                queue.push(current.left);
            }
            i++;
            if(i < values.length && values[i] !== null)
            {
                current.right = new TreeNode(values[i]);
                queue.push(current.right);
            }
            i++;
        }
        return this.root;
    }
    construct_binary_tree_from_preorder_and_inorder_traversal(preorder, inorder)
    {
        if(preorder.length === 0 || inorder.length === 0)
            return null;
        let root = new TreeNode(preorder[0]);
        let i = inorder.indexOf(preorder[0]);
        let left_inorder = inorder.slice(0, i);
        let right_inorder = inorder.slice(i + 1);
        let left_preorder = preorder.slice(1, i + 1);
        let right_preorder = preorder.slice(i + 1);
        root.left = this.construct_binary_tree_from_preorder_and_inorder_traversal(left_preorder, left_inorder);
        root.right = this.construct_binary_tree_from_preorder_and_inorder_traversal(right_preorder, right_inorder);
        return root;
    }
}

let root = new TreeNode().insert_level_order([3,9,20,15,7]);
console.log(root.construct_binary_tree_from_preorder_and_inorder_traversal([3,9,20,15,7], [9,3,15,20,7]));
