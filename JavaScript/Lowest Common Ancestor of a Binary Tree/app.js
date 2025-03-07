/*Example 1:


Input: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 1
Output: 3
Explanation: The LCA of nodes 5 and 1 is 3.
Example 2:


Input: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 4
Output: 5
Explanation: The LCA of nodes 5 and 4 is 5, since a node can be a descendant of itself according to the LCA definition.
Example 3:

Input: root = [1,2], p = 1, q = 2
Output: 1*/
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
    solve_lowest_common_ancestor_of_a_binary_tree(root, p, q)
    {
        if(root === null)
            return null;
        if(root === p || root === q)
            return root;
        let left = this.solve_lowest_common_ancestor_of_a_binary_tree(root.left, p, q);
        let right = this.solve_lowest_common_ancestor_of_a_binary_tree(root.right, p, q);
        if(left !== null && right !== null)
            return root;
        return left !== null ? left : right;
    }
}