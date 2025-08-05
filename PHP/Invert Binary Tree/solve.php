<?php

/*
Example 1:

Input: root = [4,2,7,1,3,6,9]
Output: [4,7,2,9,6,3,1]
Example 2:

Input: root = [2,1,3]
Output: [2,3,1]
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
    public function inser_level_order($values)
    {
        if (empty($values))
            return null;
        $this->val = $values[0];
        $queue = [$this];
        $i = 1;
        while ($queue && $i < count($values))
        {
            $current = array_shift($queue);
            if ($values[$i] !== null)
            {
                $current->left = new TreeNode($values[$i]);
                $queue[] = $current->left;
            }
            $i++;
            if ($i < count($values) && $values[$i] !== null)
            {
                $current->right = new TreeNode($values[$i]);
                $queue[] = $current->right;
            }
            $i++;
        }
        return $this;
    }
    public function solve_invertTree($root)
    {
        if ($root === null)
            return null;
        $temp = $root->left;
        $root->left = $root->right;
        $root->right = $temp;
        $this->solve_invertTree($root->left);
        $this->solve_invertTree($root->right);
        return $root;
    }
}

$test = new TreeNode();
$test->inser_level_order([4,2,7,1,3,6,9]);
$test->solve_invertTree($test);
print_r($test);
