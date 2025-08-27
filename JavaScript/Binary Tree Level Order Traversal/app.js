/*
Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: [[3],[9,20],[15,7]]
Example 2:

Input: root = [1]
Output: [[1]]
Example 3:

Input: root = []
Output: []
*/

class TreeNode
{
    constructor(val = 0, left = null, right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
    insert_bfs_tree(data)
    {
        if (!data)
        {
            return null;
        }
        this.val = data.shift();
        let queue = [this];
        while (queue.length > 0)
        {
            let node = queue.shift();
            if (data.length > 0)
            {
                node.left = new TreeNode(data.shift());
                queue.push(node.left);
            }
            if (data.length > 0)
            {
                node.right = new TreeNode(data.shift());
                queue.push(node.right);
            }
        }
        return this;
    }
    solve_binary_tree_level_order_traversal(root)
    {
        if (!root)
        {
            return [];
        }
        let queue = [root];
        let result = [];
        while (queue.length > 0)
        {
            let levelSize = queue.length;
            let levelOrder = [];
            for (let i = 0; i < levelSize; i++)
            {
                let node = queue.shift();
                levelOrder.push(node.val);
                if (node.left)
                {
                    queue.push(node.left);
                }
                if (node.right)
                {
                    queue.push(node.right);
                }
            }
            result.push(levelOrder);
        }
        return result;
    }
}