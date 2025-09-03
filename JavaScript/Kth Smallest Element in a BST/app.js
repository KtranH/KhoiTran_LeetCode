/*
Example 1:

Input: root = [3,1,4,null,2], k = 1
Output: 1
Example 2:

Input: root = [5,3,6,2,4,null,null,1], k = 3
Output: 3
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
    solve_kth_smallest_element_in_a_bst(root, k)
    {
        if(root == null)
            return -1;
        let stack = [];
        while(root != null || stack.length > 0)
        {
            while(root != null)
            {
                stack.push(root);
                root = root.left;
            }
            root = stack.pop();
            k--;
            if(k == 0)
                return root.val;
            root = root.right;
        }
        return -1;
    }
}

test = new TreeNode();
test.insert_bfs_tree([3,1,4,null,2]);
console.log(test.solve_kth_smallest_element_in_a_bst(test, 1));