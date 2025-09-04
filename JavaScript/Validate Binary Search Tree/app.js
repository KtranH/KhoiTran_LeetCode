/*
Example 1:

Input: root = [2,1,3]
Output: true
Example 2:

Input: root = [5,1,4,null,3,6]
Output: false
*/

class TreeNode
{
    constructor(val = 0, left = null, right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
    solve_validate_binary_search_tree(root)
    {
        if(root == null) return true;
        let stack = [];
        let prev = null;
        while(root != null || stack.length > 0)
        {
            while(root != null)
            {
                stack.push(root);
                root = root.left;
            }
            root = stack.pop();
            if(prev != null && root.val <= prev.val) return false;
            prev = root;
            root = root.right;
        }
        return true;
    }
}