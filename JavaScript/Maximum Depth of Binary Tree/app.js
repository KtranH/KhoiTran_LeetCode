/*Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: 3
Example 2:

Input: root = [1,null,2]
Output: 2*/
class Node
{
    constructor(value)
    {
        this.value = value;
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
    insert_level_order(val)
    {
        if(val.length === 0) return null;
        this.root = new Node(val[0]);
        let queue = [];
        queue.push(this.root);
        let i = 1;
        while(i < val.length && queue.length > 0)
        {
            let current = queue.shift();
            if(val[i] !== null)
            {
                current.left = new Node(val[i]);
                queue.push(current.left);
            }
            i++;
            if(i < val.length && val[i] !== null)
            {
                current.right = new Node(val[i]);
                queue.push(current.right);
            }
            i++;
        }
        return this.root;
    }
    solve_maximum_depth_of_binary_tree(node)
    {
        if(node === null) return 0;
        return 1 + Math.max(this.solve_maximum_depth_of_binary_tree(node.left), this.solve_maximum_depth_of_binary_tree(node.right));
    }
}

let test = new TreeNode();
let root = test.insert_level_order([3,9,20,null,null,15,7]);
console.log(test.solve_maximum_depth_of_binary_tree(root)); // Output: 3
