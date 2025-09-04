<?php

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
    public $val;
    public $left;
    public $right;

    public function __construct($val = 0, $left = null, $right = null)
    {
        $this->val = $val;
        $this->left = $left;
        $this->right = $right;
    }

    public function solve_validate_binary_search_tree($root)
    {
        if ($root == null)
            return true;
        $stack = [];
        $prev = null;
        while ($root != null || count($stack) > 0)
        {
            while ($root != null)
            {
                array_push($stack, $root);
                $root = $root->left;
            }
            $root = array_pop($stack);
            $val = $root->val;
            $preVal = $prev->val ?? null;
            if ($prev != null && $val <= $preVal)
                return false;
            $prev = $root;
            $root = $root->right;
        }
        return true;
    }
}