/*
Example 1:

Input: root = [4,2,6,1,3]
Output: 1
Example 2:

Input: root = [1,0,48,null,null,12,49]
Output: 1
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
        if(data.length == 0)
        {
            return;
        }
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
        return this;
    }
    solve_minimum_absolute_difference_in_bst(root)
    {
        if(root == null)
        {
            return 0;
        }
        let stack = [];
        let prev = null;
        let result = Infinity;
        while(root != null || stack.length > 0)
        {
            while(root != null)
            {
                stack.push(root);
                root = root.left;
            }
            root = stack.pop();
            if(prev != null)
            {
                result = Math.min(result, root.val - prev.val);
            }
            prev = root;
            root = root.right;
        }
        return result;
    }
}

let root = new TreeNode();
root.insert_bfs_tree([4,2,6,1,3]);
console.log(root.solve_minimum_absolute_difference_in_bst());
