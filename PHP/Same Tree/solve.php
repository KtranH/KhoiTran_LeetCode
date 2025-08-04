<?php

/*
Example 1:


Input: p = [1,2,3], q = [1,2,3]
Output: true
Example 2:


Input: p = [1,2], q = [1,null,2]
Output: false
Example 3:


Input: p = [1,2,1], q = [1,1,2]
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
    public function insert_level_order($data)
    {
        if(!$data)
        {
            return null;
        }
        $this->root = new Node($data[0]);
        $queue = [$this->root];
        $i = 1;
        while($queue)
        {
            $node = array_shift($queue);
            if($i < count($data) && $data[$i])
            {
                $node->left = new Node($data[$i]);
                $queue[] = $node->left;
            }
            $i++;
            if($i < count($data) && $data[$i])
            {
                $node->right = new Node($data[$i]);
                $queue[] = $node->right;
            }
            $i++;
        }
        return $this->root;
    }
    public function solve_isSameTree($p, $q)
    {
        if($p === null && $q === null)
            return true;
        if($p === null || $q === null)
            return false;
        if($p->val !== $q->val)
            return false;
        return $this->solve_isSameTree($p->left, $q->left) && $this->solve_isSameTree($p->right, $q->right);
    }
}

$p = new TreeNode();
$p->insert_level_order([1,2,3]);
$q = new TreeNode();
$q->insert_level_order([1,2,3]);
echo $p->solve_isSameTree($p, $q);
