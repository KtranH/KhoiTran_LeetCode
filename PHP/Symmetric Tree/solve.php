<?php

/*
Example 1:


Input: root = [1,2,2,3,4,4,3]
Output: true
Example 2:


Input: root = [1,2,2,null,3,null,3]
Output: false
*/

class TreeNode
{
    public function __construct($val = 0, $left = null, $right = null)
    {
        $this->val = $val;
        $this->left = $left;
        $this->right = $right;
    }
    public function insert_level_order($values)
    {
        if (count($values) === 0)
            return null;
        $this->val = $values[0];
        $queue = array($this);
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
    public function solve_isSymmetric($root)
    {
        if ($root === null)
            return true;
        return $this->isMirror($root->left, $root->right);
    }
    private function isMirror($t1, $t2)
    {
        if ($t1 === null && $t2 === null)
            return true;
        if ($t1 === null || $t2 === null)
            return false;
        return $t1->val === $t2->val && $this->isMirror($t1->left, $t2->right) && $this->isMirror($t1->right, $t2->left);
    }
}

$test = new TreeNode();
$test->insert_level_order(array(1, 2, 2, 3, 4, 4, 3));
echo $test->solve_isSymmetric($test);