<?php

/*
Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: [3.00000,14.50000,11.00000]
Explanation: The average value of nodes on level 0 is 3, on level 1 is 14.5, and on level 2 is 11.
Hence return [3, 14.5, 11].
Example 2:

Input: root = [3,9,20,15,7]
Output: [3.00000,14.50000,11.00000]
Explanation: The average value of nodes on level 0 is 3, on level 1 is 14.5, and on level 2 is 11.
Hence return [3, 14.5, 11].
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
        if ($values == null || count($values) == 0)
        {
            return;
        }
        $queue = array($this);
        $i = 0;
        while (count($queue) > 0)
        {
            $node = array_shift($queue);
            if ($i < count($values))
            {
                $node->left = new TreeNode($values[$i++]);
                $queue[] = $node->left;
            }
            if ($i < count($values))
            {
                $node->right = new TreeNode($values[$i++]);
                $queue[] = $node->right;
            }
        }
    }
    public function solve_average_of_levels_in_binary_tree()
    {
        if ($this == null)
        {
            return array();
        }
        $queue = array($this);
        $result = array();
        while (count($queue) > 0)
        {
            $levelSize = count($queue);
            $levelSum = 0;
            for ($i = 0; $i < $levelSize; $i++)
            {
                $node = array_shift($queue);
                $levelSum += $node->val;
                if ($node->left != null)
                {
                    $queue[] = $node->left;
                }
                if ($node->right != null)
                {
                    $queue[] = $node->right;
                }
            }
            $result[] = $levelSum / $levelSize;
        }
        return $result;
    }
}

$root = new TreeNode();
$root->insert_level_order(array(3, 9, 20, null, null, 15, 7));
print_r($root->solve_average_of_levels_in_binary_tree());
