<?php

/*
Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: [[3],[20,9],[15,7]]
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
        if (count($data) == 0)
            return;
        $this->val = $data[0];
        $queue = [];
        $queue[] = $this;
        $i = 1;
        while (count($queue) > 0)
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
    }
    public function solve_binary_tree_zigzag_level_order_traversal()
    {
        if ($this == null)
            return [];
        $queue = [];
        $queue[] = $this;
        $result = [];
        $left_to_right = true;
        while (count($queue) > 0)
        {
            $level_size = count($queue);
            $level_order = [];
            for ($i = 0; $i < $level_size; $i++)
            {
                $node = array_shift($queue);
                if ($left_to_right)
                    $level_order[] = $node->val;
                else
                    array_unshift($level_order, $node->val);
                if ($node->left != null)
                    $queue[] = $node->left;
                if ($node->right != null)
                    $queue[] = $node->right;
            }
            $result[] = $level_order;
            $left_to_right = !$left_to_right;
        }
        return $result;
    }
}

$root = new TreeNode();
$root->insert_bfs_tree([3, 9, 20, null, null, 15, 7]);
echo $root->solve_binary_tree_zigzag_level_order_traversal();
