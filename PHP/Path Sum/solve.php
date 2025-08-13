<?php

/*
Example 1:

Input: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
Output: true
Explanation: The root-to-leaf path with the target sum is shown.
Example 2:

Input: root = [1,2,3], targetSum = 5
Output: false
Explanation: There two root-to-leaf paths in the tree:
(1 --> 2): The sum is 3.
(1 --> 3): The sum is 4.
There is no root-to-leaf path with sum = 5.
Example 3:

Input: root = [], targetSum = 0
Output: false
Explanation: Since the tree is empty, there are no root-to-leaf paths.
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
        if (count($values) == 0)
            return null;
        $this->val = $values[0];
        $queue = [$this];
        $i = 1;
        while ($i < count($values) && count($queue) > 0)
        {
            $current = array_shift($queue);
            if ($values[$i] != null)
            {
                $current->left = new TreeNode($values[$i]);
                $queue[] = $current->left;
            }
            $i++;
            if ($i < count($values) && $values[$i] != null)
            {
                $current->right = new TreeNode($values[$i]);
                $queue[] = $current->right;
            }
            $i++;
        }
        return $this;
    }
    public function solve_path_sum($root, $target_sum)
    {
        if ($root == null)
            return false;
        if ($root->left == null && $root->right == null && $root->val == $target_sum)
            return true;
        return $this->solve_path_sum($root->left, $target_sum - $root->val) || $this->solve_path_sum($root->right, $target_sum - $root->val);
    }
}
$root = new TreeNode();
$root->insert_level_order([5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1]);
echo $root->solve_path_sum($root, 22);