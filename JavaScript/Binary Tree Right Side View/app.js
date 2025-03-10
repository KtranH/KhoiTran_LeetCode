/*Example 1:

Input: root = [1,2,3,null,5,null,4]

Output: [1,3,4]

Explanation:



Example 2:

Input: root = [1,2,3,4,null,null,null,5]

Output: [1,3,4,5]

Explanation:



Example 3:

Input: root = [1,null,3]

Output: [1,3]

Example 4:

Input: root = []

Output: []*/


class Node
{
    constructor(data)
    {
        this.val = data
        this.left = null
        this.right = null
    }
}
class TreeNode
{
    constructor()
    {
        this.root = null
    }
    insert_level_order(data)
    {
        if(!data)
        {
            return null
        }
        this.root = new Node(data[0])
        queue = [this.root]
        i = 1
        while(queue)
        {
            node = queue.pop(0)
            if(i < data.length && data[i])
            {
                node.left = new Node(data[i])
                queue.push(node.left)
            }
            i++
            if(i < data.length && data[i])
            {
                node.right = new Node(data[i])
                queue.push(node.right)
            }
            i++
        }
        return this.root
    }
    solve_binary_tree_right_side_view(root)
    {
        if(root == null)
        {
            return []
        }
        queue = [root]
        result = []
        while(queue.length > 0)
        {
            level_size = queue.length
            for(i = 0; i < level_size; i++)
            {
                node = queue.shift()
                if(i == level_size - 1)
                {
                    result.push(node.val)
                }
                if(node.left)
                {
                    queue.push(node.left)
                }
                if(node.right)
                {
                    queue.push(node.right)
                }
            }
        }
        return result
    }
}

let test = new TreeNode()

root = test.insert_level_order([1,2,3,null,5,null,4])

console.log(test.solve_binary_tree_right_side_view(root))
