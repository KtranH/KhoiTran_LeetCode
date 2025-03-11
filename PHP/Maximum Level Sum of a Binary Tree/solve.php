<?php 
class Node
{
    public $val;
    public $left;
    public $right;
    public function __construct($val)
    {
        $this->val = $val;
        $this->left = null;
        $this->right = null;
    }
}
class TreeNode
{
    public $root;
    public function __construct()
    {
        $this->root = null;
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
        while($queue && $i < count($data))
        {
            $node = array_shift($queue);
            if($data[$i])
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
    public function solve_maximum_level_sum($root)
    {
        if($root == null)
        {
            return 0;
        }
        $max_level_tree = 0;
        $level_tree = 0;
        $max_values = -INF;
        $queue = [$root];
        while(count($queue) > 0)
        {
            $level_tree++;
            $count = count($queue);
            $level_sum = 0;
            for($i = 0; $i < $count; $i++)
            {
                $node = array_shift($queue);
                $level_sum += $node->val;
                if($node->left) $queue[] = $node->left;
                if($node->right) $queue[] = $node->right;
            }
            if($level_sum > $max_values)
            {
                $max_values = $level_sum;
                $max_level_tree = $level_tree;
            }
        }
        return $max_level_tree;
    }
}