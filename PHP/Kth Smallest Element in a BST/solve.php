<?php

/*
Example 1:

Input: root = [3,1,4,null,2], k = 1
Output: 1
Example 2:

Input: root = [5,3,6,2,4,null,null,1], k = 3
Output: 3
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
    public function solve_kth_smallest_element_in_a_bst($root, $k)
    {
        if ($root == null)
            return -1;
        $stack = [];
        while ($root != null || count($stack) > 0)
        {
            while ($root != null)
            {
                array_push($stack, $root);
                $root = $root->left;
            }
            $root = array_pop($stack);
            $k--;
            if ($k == 0)
                return $root->val;
            $root = $root->right;
        }
        return -1;
    }
}

$root = new TreeNode();
$root->insert_bfs_tree([3, 1, 4, null, 2]);
$k = 1;
$result = $root->solve_kth_smallest_element_in_a_bst($root, $k);
echo $result;
