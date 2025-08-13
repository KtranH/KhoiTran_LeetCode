/*
Example 1:

Input: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
Output: true
Explanation: The root-to-leaf path with the target sum is shown.
Example 2:

Input: root = [1,2,3], targetSum = 5
Output: false
Explanation: There two root-to-leaf paths in the tree:
(1 --> 2): The sum is 3.
(1 --> 3): The sum is 4.
There is no root-to-leaf path with sum = 5.
Example 3:

Input: root = [], targetSum = 0
Output: false
Explanation: Since the tree is empty, there are no root-to-leaf paths.
*/

class TreeNode
{
    constructor(val, left, right)
    {
        this.val = (val===undefined ? 0 : val)
        this.left = (left===undefined ? null : left)
        this.right = (right===undefined ? null : right)
    }
    insert_level_order(values)
    {
        if (values.length == 0)
            return null;
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
        return this;
    }
    solve_path_sum(root, target_sum)
    {
        if (root == null)
            return false;
        if (root.left == null && root.right == null && root.val == target_sum)
            return true;
        return this.solve_path_sum(root.left, target_sum - root.val) || this.solve_path_sum(root.right, target_sum - root.val);
    }
}
let root = new TreeNode();
root.insert_level_order([5,4,8,11,null,13,4,7,2,null,null,null,1]);
console.log(root.solve_path_sum(root, 22));