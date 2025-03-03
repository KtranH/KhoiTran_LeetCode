/*Example 1:


Input: root1 = [3,5,1,6,2,9,8,null,null,7,4], root2 = [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]
Output: true
Example 2:


Input: root1 = [1,2,3], root2 = [1,3,2]
Output: false*/
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
    }
    DFS(root)
    {
        if(root === null)
            return []
        if(root.left === null && root.right === null)
            return [root.value];
        return this.DFS(root.left).concat(this.DFS(root.right));
    }
    solve_leaf_similar_trees(root1, root2)
    {
        return this.DFS(root1).toString() === this.DFS(root2).toString();
    }
}

let test = new TreeNode();
let root1 = test.insert_level_order([3,5,1,6,2,9,8,null,null,7,4]);
let root2 = test.insert_level_order([3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]);
console.log(test.solve_leaf_similar_trees(root1, root2)); // Output: true