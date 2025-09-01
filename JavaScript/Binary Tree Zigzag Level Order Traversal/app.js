/*
Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: [[3],[20,9],[15,7]]
Example 2:

Input: root = [1]
Output: [[1]]
Example 3:

Input: root = []
Output: []
*/

class TreeNode
{
    constructor(val, left, right)
    {
        this.val = (val === undefined ? 0 : val)
        this.left = (left === undefined ? null : left)
        this.right = (right === undefined ? null : right)
    }
    insert_bfs_tree(data)
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
    solve_binary_tree_zigzag_level_order_traversal(root)
    {
        if(root == null)
            return [];
        let queue = [];
        queue.push(root);
        let result = [];
        let left_to_right = true;
        while(queue.length > 0)
        {
            let level_size = queue.length;
            let level_order = [];
            for(let i = 0; i < level_size; i++)
            {
                let node = queue.shift();
                if(left_to_right)
                    level_order.push(node.val);
                else
                    level_order.unshift(node.val);
                if(node.left != null)
                    queue.push(node.left);
                if(node.right != null)
                    queue.push(node.right);
            }
            result.push(level_order);
            left_to_right = !left_to_right;
        }
        return result;
    }
}

let root = new TreeNode();
root.insert_bfs_tree([3,9,20,null,null,15,7]);
console.log(root.solve_binary_tree_zigzag_level_order_traversal(root));
