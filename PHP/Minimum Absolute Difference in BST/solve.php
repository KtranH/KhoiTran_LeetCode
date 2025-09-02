<?php

/*
Example 1:

Input: root = [4,2,6,1,3]
Output: 1
Example 2:

Input: root = [1,0,48,null,null,12,49]
Output: 1
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
        return $this;
    }
    public function solve_minimum_absolute_difference_in_bst($root)
    {
        if ($root == null)
        {
            return 0;
        }
        $stack = [];
        $prev = null;
        $result = PHP_INT_MAX;
        while ($root != null || count($stack) > 0)
        {
            while ($root != null)
            {
                $stack[] = $root;
                $root = $root->left;
            }
            $root = array_pop($stack);
            if ($prev != null)
            {
                $rootVal = $root->val ?? 0;
                $prevVal = $prev->val ?? 0;
                $result = min($result, $rootVal - $prevVal);
            }
            $prev = $root;
            $root = $root->right;
        }
        return $result;
    }
}

$root = new TreeNode();
$root->insert_bfs_tree([4,2,6,1,3]);
echo $root->solve_minimum_absolute_difference_in_bst($root);