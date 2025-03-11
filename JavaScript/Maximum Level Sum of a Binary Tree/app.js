/*Example 1:


Input: root = [1,7,0,7,-8,null,null]
Output: 2
Explanation: 
Level 1 sum = 1.
Level 2 sum = 7 + 0 = 7.
Level 3 sum = 7 + -8 = -1.
So we return the level with the maximum sum which is level 2.
Example 2:

Input: root = [989,null,10250,98693,-89388,null,null,null,-32127]
Output: 2*/

class Node
{
    constructor(val)
    {
        this.val = val;
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
        if(!val)
        {
            return null;
        }
        this.root = new Node(val[0]);
        const queue = [this.root];
        let i = 1;
        while(i < val.length)
        {
            const node = queue.shift();
            if(val[i] !== null)
            {
                node.left = new Node(val[i]);
                queue.push(node.left);
            }
            i++;
            if(i < val.length && val[i] !== null)
            {
                node.right = new Node(val[i]);
                queue.push(node.right);
            }
            i++;
        }
        return this.root;
    }
    solve_maximum_level_sum(root)
    {
        if(!root)
        {
            return 0;
        }
        let max_level_tree = 0;
        let level_tree = 0;
        let max_values = -Infinity;
        const queue = [root];
        while(queue.length > 0)
        {
            level_tree++;
            const count = queue.length;
            let level_sum = 0;
            for(let i = 0; i < count; i++)
            {
                const node = queue.shift();
                level_sum += node.val;
                if(node.left) queue.push(node.left);
                if(node.right) queue.push(node.right);
            }
            if(level_sum > max_values)
            {
                max_values = level_sum;
                max_level_tree = level_tree;
            }
        }
        return max_level_tree;
    }
}

const test = new TreeNode();
const root = test.insert_level_order([1,7,0,7,-8,null,null]);
console.log(test.solve_maximum_level_sum(root));
