<?php

/*
Example 1:

Input: root = [1,2,3]
Output: 25
Explanation:
The root-to-leaf paths are:
1 -> 2: 12
1 -> 3: 13
Therefore, sum = 12 + 13 = 25.

Example 2:

Input: root = [4,9,0,5,1]
Output: 1026
Explanation:
The root-to-leaf paths are:
4 -> 9 -> 5: 495
4 -> 9 -> 1: 491
4 -> 0: 40
Therefore, sum = 495 + 491 + 40 = 1026.
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
    public function insert_level_order($values)
    {
        if (empty($values))
            return null;
        $this->val = $values[0];
        $queue = [$this];
        $i = 1;
        while ($i < count($values) && count($queue) > 0)
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
    public function DFS($root, $current_sum)
    {
        if (!$root)
            return 0;
        $current_sum = $current_sum * 10 + $root->val;
        if (!$root->left && !$root->right)
            return $current_sum;
        return $this->DFS($root->left, $current_sum) + $this->DFS($root->right, $current_sum);
    }
    public function solve_sum_root_to_leaf($root)
    {
        return $this->DFS($root, 0);
    }
}

$root = new TreeNode();
$root->insert_level_order([1,2,3]);
echo $root->solve_sum_root_to_leaf($root);
