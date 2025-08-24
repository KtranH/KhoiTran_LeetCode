/*
Example 1:

Input: root = [1,2,3,4,5,6]
Output: 6
Example 2:

Input: root = []
Output: 0
Example 3:

Input: root = [1]
Output: 1
*/

class TreeNode
{
    constructor()
    {
        this.val = 0;
        this.left = null;
        this.right = null;
    }
    insert_level_order(data)
    {
        if(data.length == 0)
            return;
        this.val = data[0];
        let queue = [];
        queue.push(this);
        let i = 1;
        while(queue.length > 0)
        {
            let node = queue.shift();
            if(i < data.length && data[i] != null)
            {
                node.left = new TreeNode(data[i]);
                queue.push(node.left);
            }
            i++;
            if(i < data.length && data[i] != null)
            {
                node.right = new TreeNode(data[i]);
                queue.push(node.right);
            }
            i++;
        }
    }
    solve_count_complete_tree_nodes(root)
    {
        if(root == null)
            return 0;
        return 1 + this.solve_count_complete_tree_nodes(root.left) + this.solve_count_complete_tree_nodes(root.right);
    }
}

let tree = new TreeNode();
let root = tree.insert_level_order([1,2,3,4,5,6]);
console.log(tree.solve_count_complete_tree_nodes(root));
