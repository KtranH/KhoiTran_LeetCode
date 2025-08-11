/*
Example 1:

Input: root = [1,2,3,4,5,null,7]
Output: [1,#,2,3,#,4,5,7,#]
Explanation: Given the above binary tree (Figure A), your function should populate each next pointer to point to its next right node, just like in Figure B. The serialized output is in level order as connected by the next pointers, with '#' signifying the end of each level.
Example 2:

Input: root = []
Output: []
*/

class TreeNode
{
    constructor(val = 0, left = null, right = null, next = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
        this.next = next;
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
    solve_populating_next_right_pointers_in_each_node_ii(root)
    {
        let result = root;
        while(root !== null)
        {
            let dummy = new TreeNode(0);
            let tail = dummy;
            let curr = root;
            while(curr !== null)
            {
                if(curr.left !== null)
                {
                    tail.next = curr.left;
                    tail = tail.next;
                }
                if(curr.right !== null)
                {
                    tail.next = curr.right;
                    tail = tail.next;
                }
                curr = curr.next;
            }
            root = dummy.next;
        }   
        return result;
    }
}

let root = new TreeNode();
root.insert_level_order([1,2,3,4,5,null,7]);
root.solve_populating_next_right_pointers_in_each_node_ii(root);
console.log(root);
