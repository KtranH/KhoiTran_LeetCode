/*Example 1:


Input: root = [1,null,1,1,1,null,null,1,1,null,1,null,null,null,1]
Output: 3
Explanation: Longest ZigZag path in blue nodes (right -> left -> right).
Example 2:


Input: root = [1,1,1,null,1,null,null,1,1,null,1]
Output: 4
Explanation: Longest ZigZag path in blue nodes (left -> right -> left -> right).
Example 3:

Input: root = [1]
Output: 0*/
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
        this.max_length = 0;
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
    DFS(node, direction, length)
    {
        if(node === null)
        {
            return;
        }
        if(length > this.max_length)
        {
            this.max_length = length;
        }
        if(direction === "left")
        {
            this.DFS(node.right, "right", length + 1);
            this.DFS(node.left, "left", 1);
        }
        else
        {
            this.DFS(node.left, "left", length + 1);
            this.DFS(node.right, "right", 1);
        }
    }
    solve_longest_zigzag_path_in_a_binary_tree(root)
    {
        this.DFS(root, "left", 0);
        this.DFS(root, "right", 0);
        return this.max_length;
    }
}

let test = new TreeNode();

let root = test.insert_level_order([1,null,1,1,1,null,null,1,1,null,1,null,null,null,1]);

console.log(test.solve_longest_zigzag_path_in_a_binary_tree(root)); // Output: 3
