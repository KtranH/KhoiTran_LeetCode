/*Example 1:


Input: root = [10,5,-3,3,2,null,11,3,-2,null,1], targetSum = 8
Output: 3
Explanation: The paths that sum to 8 are shown.
Example 2:

Input: root = [5,4,8,11,null,13,4,7,2,null,null,5,1], targetSum = 22
Output: 3*/
class Node
{
    constructor(data)
    {
        this.val = data;
        this.left = null;
        this.right = null;
    }
}
class TreeNode
{
    constructor()
    {
        this.root = null;
    }
    insert_level_order(values)
    {
        if(values.length === 0)
            return null;
        this.root = new Node(values[0]);
        let queue = [this.root];
        let i = 1;
        while(i < values.length && queue.length > 0)
        {
            let current = queue.shift();
            if(values[i] !== null)
            {
                current.left = new Node(values[i]);
                queue.push(current.left);
            }
            i++;
            if(i < values.length && values[i] !== null)
            {
                current.right = new Node(values[i]);
                queue.push(current.right);
            }
            i++;
        }
        return this.root;
    }
    DFS(root, hashmap_sum, currentSum, targetSum)
    {
        if(root === null)
            return 0;
        let count = 0;
        currentSum += root.val;
        count = hashmap_sum.get(currentSum - targetSum) || 0;
        hashmap_sum.set(currentSum, (hashmap_sum.get(currentSum) || 0) + 1);
        count += this.DFS(root.left, hashmap_sum, currentSum, targetSum);
        count += this.DFS(root.right, hashmap_sum, currentSum, targetSum);
        hashmap_sum.set(currentSum, hashmap_sum.get(currentSum) - 1);
        return count;
    }
    solve_path_sum_iii(root, targetSum = 8)
    {
        let hashmap_sum = new Map();
        hashmap_sum.set(0, 1);
        return this.DFS(root, hashmap_sum, 0, targetSum);
    }
}

let tree = new TreeNode();

let root = tree.insert_level_order([10,5,-3,3,2,null,11,3,-2,null,1]);

console.log(tree.solve_path_sum_iii(root)); // Output: 3