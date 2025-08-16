/*
Example 1:

Input: root = [1,2,3]
Output: 25
Explanation:
The root-to-leaf paths are:
1 -> 2: 12
1 -> 3: 13
Therefore, sum = 12 + 13 = 25.

Example 2:

Input: root = [4,9,0,5,1]
Output: 1026
Explanation:
The root-to-leaf paths are:
4 -> 9 -> 5: 495
4 -> 9 -> 1: 491
4 -> 0: 40
Therefore, sum = 495 + 491 + 40 = 1026.
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
    DFS(root, current_sum)
    {
        if (!root)
            return 0;
        current_sum = current_sum * 10 + root.val;
        if (!root.left && !root.right)
            return current_sum;
        return this.DFS(root.left, current_sum) + this.DFS(root.right, current_sum);
    }
    solve_sum_root_to_leaf(root)
    {
        return this.DFS(root, 0);
    }
}

let root = new TreeNode();
root.insert_level_order([1,2,3]);
console.log(root.solve_sum_root_to_leaf(root));
