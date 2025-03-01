<?php 

/*Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: 3
Example 2:

Input: root = [1,null,2]
Output: 2*/

class Node
{
    public $val;
    public $left;
    public $right;
    function __construct($val = 0, $left = null, $right = null) {
        $this->val = $val;
        $this->left = $left;
        $this->right = $right;
    }
}
class TreeNode
{
    public $root;
    function __construct() {
        $this->root = null;
    }
    public function insert_level_order($val)
    {
        if(count($val) == 0)
            return null;
        $this->root = new Node($val[0]);
        $queue = array();
        array_push($queue, $this->root);
        $i = 1;
        while($i < count($val) && count($queue) > 0)
        {
            $current = array_shift($queue);
            if($val[$i] !== null)
            {
                $current->left = new Node($val[$i]);
                array_push($queue, $current->left);
            }
            $i++;
            if($i < count($val) && $val[$i] !== null)
            {
                $current->right = new Node($val[$i]);
                array_push($queue, $current->right);
            }
            $i++;
        }
        return $this->root;
    }
    public function solve_maximum_depth_of_binary_tree($node)
    {
        if($node == null)
            return 0;
        $left = $this->solve_maximum_depth_of_binary_tree($node->left);
        $right = $this->solve_maximum_depth_of_binary_tree($node->right);
        $max = max($left, $right) + 1;
        return $max;
    }
}

$tree = new TreeNode();
echo $tree->solve_maximum_depth_of_binary_tree($tree->insert_level_order([3,9,20,null,null,15,7])); // 3