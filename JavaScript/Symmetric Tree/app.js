/*
Example 1:


Input: root = [1,2,2,3,4,4,3]
Output: true
Example 2:


Input: root = [1,2,2,null,3,null,3]
Output: false
*/

class TreeNode
{
    constructor(val, left, right)
    {
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
    solve_isSymmetric(root)
    {
        if(root === null)
            return true;
        return this.isMirror(root.left, root.right);
    }
    isMirror(t1, t2)
    {
        if(t1 === null && t2 === null)
            return true;
        if(t1 === null || t2 === null)
            return false;
        return t1.val === t2.val && this.isMirror(t1.left, t2.right) && this.isMirror(t1.right, t2.left);
    }
}

let test = new TreeNode();
test.insert_level_order([1,2,2,3,4,4,3]);
console.log(test.solve_isSymmetric(test.root));
