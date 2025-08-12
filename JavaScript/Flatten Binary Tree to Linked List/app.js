/*
Example 1:

Input: root = [1,2,5,3,4,null,6]
Output: [1,null,2,null,3,null,4,null,5,null,6]
Example 2:

Input: root = []
Output: []
Example 3:

Input: root = [0]
Output: [0]
*/

class TreeNode
{
    prev = null;
    constructor(val = 0, left = null, right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
    insert_level_order(values)
    {
        if (values.length == 0)
        {
            return null;
        }
        this.val = values[0];
        let queue = [this];
        let i = 1;
        while (i < values.length && queue.length > 0)
        {
            let current = queue.shift();
            if (values[i] != null)
            {
                current.left = new TreeNode(values[i]);
                queue.push(current.left);
            }
            i++;
            if (i < values.length && values[i] != null)
            {
                current.right = new TreeNode(values[i]);
                queue.push(current.right);
            }
            i++;
        }
    }
    solve_flatten_binary_tree_to_linked_list(root)
    {
        if (root == null)
        {
            return;
        }
        this.solve_flatten_binary_tree_to_linked_list(root.right);
        this.solve_flatten_binary_tree_to_linked_list(root.left);
        root.right = this.prev;
        root.left = null;
        this.prev = root;
    }
}

let root = new TreeNode();
root.insert_level_order([1, 2, 5, 3, 4, null, 6]);
root.solve_flatten_binary_tree_to_linked_list(root);
console.log(root);
