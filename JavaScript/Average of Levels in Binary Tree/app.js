/*
Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: [3.00000,14.50000,11.00000]
Explanation: The average value of nodes on level 0 is 3, on level 1 is 14.5, and on level 2 is 11.
Hence return [3, 14.5, 11].
Example 2:

Input: root = [3,9,20,15,7]
Output: [3.00000,14.50000,11.00000]
Explanation: The average value of nodes on level 0 is 3, on level 1 is 14.5, and on level 2 is 11.
Hence return [3, 14.5, 11].
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
        if (values == null || values.length == 0)
        {
            return;
        }
        let queue = [this];
        let i = 0;
        while (queue.length > 0)
        {
            let node = queue.shift();
            if (i < values.length)
            {
                node.left = new TreeNode(values[i++]);
                queue.push(node.left);
            }
            if (i < values.length)
            {
                node.right = new TreeNode(values[i++]);
                queue.push(node.right);
            }
        }
    }
    solve_average_of_levels_in_binary_tree()
    {
        if (this == null)
        {
            return [];
        }
        let queue = [this];
        let result = [];
        while (queue.length > 0)
        {
            let levelSize = queue.length;
            let levelSum = 0;
            for (let i = 0; i < levelSize; i++)
            {
                let node = queue.shift();
                levelSum += node.val;
                if (node.left != null)
                {
                    queue.push(node.left);
                }
                if (node.right != null)
                {
                    queue.push(node.right);
                }
            }
            result.push(levelSum / levelSize);
        }
        return result;
    }
}

let root = new TreeNode();
root.insert_level_order([3,9,20,null,null,15,7]);
console.log(root.solve_average_of_levels_in_binary_tree());
