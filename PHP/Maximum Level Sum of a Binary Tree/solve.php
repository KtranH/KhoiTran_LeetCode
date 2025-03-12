<?php 

/*Example 1:


Input: root = [1,7,0,7,-8,null,null]
Output: 2
Explanation: 
Level 1 sum = 1.
Level 2 sum = 7 + 0 = 7.
Level 3 sum = 7 + -8 = -1.
So we return the level with the maximum sum which is level 2.
Example 2:

Input: root = [989,null,10250,98693,-89388,null,null,null,-32127]
Output: 2*/


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

$test = new TreeNode();
$root = $test->insert_level_order([1,7,0,7,-8,null,null]);
print_r($test->solve_maximum_level_sum($root));
