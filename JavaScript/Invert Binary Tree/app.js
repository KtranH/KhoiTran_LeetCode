/*
Example 1:

Input: root = [4,2,7,1,3,6,9]
Output: [4,7,2,9,6,3,1]
Example 2:

Input: root = [2,1,3]
Output: [2,3,1]
Example 3:

Input: root = []
Output: []
*/

class TreeNode
{
    constructor(val, left = null, right = null)
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
    solve_invertTree(root)
    {
        if(root === null)
            return null;
        let temp = root.left;
        root.left = root.right;
        root.right = temp;
        this.solve_invertTree(root.left);
        this.solve_invertTree(root.right);
        return root;
    }
}

let test = new TreeNode();
test.insert_level_order([4,2,7,1,3,6,9]);
test.solve_invertTree(test.root);
console.log(test.root);
