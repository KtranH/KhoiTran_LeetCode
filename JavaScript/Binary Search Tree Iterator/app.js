/*
Example 1:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]

Example 2:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]

Example 3:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]

Example 4:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]

Example 5:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]
*/

class TreeNode
{
    constructor()
    {
        this.val = 0;
        this.left = null;
        this.right = null;
        this.stack = [];
        this._push_left(this);
    }
    
    _push_left(node)
    {
        while(node)
        {
            this.stack.push(node);
            node = node.left;
        }
    }
    
    next()
    {
        let node = this.stack.pop();
        this._push_left(node.right);
        return node.val;
    }
    
    hasNext()
    {
        return this.stack.length > 0;
    }
}

let root = new TreeNode();
root.insert_level_order([7,3,15,null,null,9,20]);
while(root.hasNext())
{
    console.log(root.next());
}