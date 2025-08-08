/*
Example 1:

Input: inorder = [9,3,15,20,7], postorder = [9,15,7,20,3]
Output: [3,9,20,null,null,15,7]
Example 2:

Input: inorder = [-1], postorder = [-1]
Output: [-1]
 
*/

class TreeNode
{
    constructor(val = 0, left = null, right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
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
    solve_construct_binary_tree_from_inorder_and_postorder_traversal(inorder, postorder)
    {
        if(inorder.length === 0 || postorder.length === 0)
            return null;
        let root = new TreeNode(postorder[postorder.length - 1]);
        let i = inorder.indexOf(postorder[postorder.length - 1]);
        let leftInorder = inorder.slice(0, i);
        let rightInorder = inorder.slice(i + 1);
        let leftPostorder = postorder.slice(0, i);
        let rightPostorder = postorder.slice(i, postorder.length - 1);
        root.left = this.solve_construct_binary_tree_from_inorder_and_postorder_traversal(leftInorder, leftPostorder);
        root.right = this.solve_construct_binary_tree_from_inorder_and_postorder_traversal(rightInorder, rightPostorder);
        return root;
    }
}

let root = new TreeNode();
root.insert_level_order([3,9,20,15,7]);
let result = root.solve_construct_binary_tree_from_inorder_and_postorder_traversal([9,3,15,20,7],[9,15,7,20,3]);
console.log(result);
