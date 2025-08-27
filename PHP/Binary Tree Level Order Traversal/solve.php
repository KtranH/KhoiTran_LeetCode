<?php

/*
Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: [[3],[9,20],[15,7]]
Example 2:

Input: root = [1]
Output: [[1]]
Example 3:

Input: root = []
Output: []
*/

class TreeNode
{
    public $val;
    public $left;
    public $right;
    public function __construct($val = 0, $left = null, $right = null)
    {
        $this->val = $val;
        $this->left = $left;
        $this->right = $right;
    }
    public function insert_bfs_tree($data)
    {
        if (!$data)
        {
            return null;
        }
        $this->val = $data[0];
        $queue = [$this];
        $i = 1;
        while ($queue && $i < count($data))
        {
            $node = array_shift($queue);
            if ($i < count($data) && $data[$i] != null)
            {
                $node->left = new TreeNode($data[$i]);
                $queue[] = $node->left;
            }
            $i++;
            if ($i < count($data) && $data[$i] != null)
            {
                $node->right = new TreeNode($data[$i]);
                $queue[] = $node->right;
            }
            $i++;
        }
        return $this;
    }
    public function solve_binary_tree_level_order_traversal($root)
    {
        if (!$root)
        {
            return [];
        }
        $queue = [$root];
        $result = [];
        while ($queue)
        {
            $levelSize = count($queue);
            $levelOrder = [];
            for ($i = 0; $i < $levelSize; $i++)
            {
                $node = array_shift($queue);
                $levelOrder[] = $node->val;
                if ($node->left)
                {
                    $queue[] = $node->left;
                }
                if ($node->right)
                {
                    $queue[] = $node->right;
                }
            }
            $result[] = $levelOrder;
        }
        return $result;
    }
}

$root = new TreeNode();
$root->insert_bfs_tree([3, 9, 20, null, null, 15, 7]);
echo $root->solve_binary_tree_level_order_traversal($root);
