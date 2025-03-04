/*Example 1:



Input: root = [3,1,4,3,null,1,5]
Output: 4
Explanation: Nodes in blue are good.
Root Node (3) is always a good node.
Node 4 -> (3,4) is the maximum value in the path starting from the root.
Node 5 -> (3,4,5) is the maximum value in the path
Node 3 -> (3,1,3) is the maximum value in the path.
Example 2:



Input: root = [3,3,null,4,2]
Output: 3
Explanation: Node 2 -> (3, 3, 2) is not good, because "3" is higher than it.
Example 3:

Input: root = [1]
Output: 1
Explanation: Root is considered as good.*/

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
    DFS(node, max_val)
    {
        let count = 0;
        if(node == null)
            return 0;
        if(node.val >= max_val)
        {
            count = 1;
            max_val = node.val;
        }
        return count + this.DFS(node.left, max_val) + this.DFS(node.right, max_val);
    }
    solve_count_good_nodes_in_binary_tree(root)
    {
        return this.DFS(root, root.val);
    }
}

let tree = new TreeNode();
let root = tree.insert_level_order([3,1,4,3,null,1,5]);
console.log(tree.solve_count_good_nodes_in_binary_tree(root)); // 4