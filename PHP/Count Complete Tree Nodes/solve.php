<?php

/*
Example 1:

Input: root = [1,2,3,4,5,6]
Output: 6
Example 2:

Input: root = []
Output: 0
Example 3:

Input: root = [1]
Output: 1
*/

class TreeNode
{
    public $val;
    public $left;
    public $right;
    public function __construct($val = 0, $left = null, $right = null) {
        $this->val = $val;
        $this->left = $left;
        $this->right = $right;
    }
    public function insert_level_order($data)
    {
        if (count($data) == 0)
        {
            return;
        }
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
    public function solve_count_complete_tree_nodes($root)
    {
        if ($root == null)
        {
            return 0;
        }
        return 1 + $this->solve_count_complete_tree_nodes($root->left) + $this->solve_count_complete_tree_nodes($root->right);
    }
}

$root = new TreeNode();
$root->insert_level_order([1,2,3,4,5,6]);
echo $root->solve_count_complete_tree_nodes($root);
