/*Example 1:


Input: root = [4,2,7,1,3], val = 2
Output: [2,1,3]
Example 2:


Input: root = [4,2,7,1,3], val = 5
Output: []*/

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
    insert(val)
    {
        if(this.root == null)
        {
            this.root = new Node(val);
        }
        else
        {
            this._insert_recursive(this.root, val);
        }
    }
    _insert_recursive(node, val)
    {
        if (node.val > val)
        {
            if (node.left == null)
            {
                node.left = new Node(val);
            }
            else
            {
                this._insert_recursive(node.left, val);
            }
        }
        else
        {
            if (node.right == null)
            {
                node.right = new Node(val);
            }
            else
            {
                this._insert_recursive(node.right, val);
            }
        }
    }
    solve_search_in_a_search_tree(val)
    {
        while(this.root && this.root.val != val)
        {
            if(this.root.val > val)
            {
                this.root = this.root.left;
            }
            else
            {
                this.root = this.root.right;
            }
        }
        return this.root;
    }
}

test = new TreeNode();
const values = [4, 2, 7, 1, 3];
for (const value of values) {
    test.insert(value);
}

console.log(test.solve_search_in_a_search_tree(2)); 