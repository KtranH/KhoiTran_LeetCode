/*
Example 1:


Input: p = [1,2,3], q = [1,2,3]
Output: true
Example 2:


Input: p = [1,2], q = [1,null,2]
Output: false
Example 3:


Input: p = [1,2,1], q = [1,1,2]
Output: false
*/

class TreeNode {
    constructor(val, left, right) {
        this.val = (val===undefined ? 0 : val)
        this.left = (left===undefined ? null : left)
        this.right = (right===undefined ? null : right)
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
            if(i < values.length && values[i] !== null)
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
}

var solve_isSameTree = function(p, q) {
    if(p === null && q === null) return true;
    if(p === null || q === null) return false;
    if(p.val !== q.val) return false;
    return solve_isSameTree(p.left, q.left) && solve_isSameTree(p.right, q.right);
};


let p = new TreeNode();
p.insert_level_order([1,2,3]);
let q = new TreeNode();
q.insert_level_order([1,2,3]);
console.log(solve_isSameTree(p, q));
