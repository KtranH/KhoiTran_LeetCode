<?php 

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
    function __construct($root = null) {
        $this->root = $root;
    }
    public function insert_level_order($arr)
    {
        if(count($arr) == 0) {
            return null;
        }
        $root = new Node($arr[0]);
        $queue = [];
        array_push($queue, $root);
        $i = 1;
        while($i < count($arr) && count($queue) > 0) {
            $node = array_shift($queue);
            if($arr[$i]!=null) {
                $node->left = new Node($arr[$i]);
                array_push($queue, $node->left);
            }
            $i++;
            if($i < count($arr) && $arr[$i]!=null) {
                $node->right = new Node($arr[$i]);
                array_push($queue, $node->right);
            }
            $i++;
        }
        return $root;
    }
    public function DFS($node, $max_val)
    {
        $count = 0;
        if($node == null)
        {
            return 0;
        }
        if($node->val >= $max_val)
        {
            $count++;
            $max_val = $node->val;
        }
        return $count + $this->DFS($node->left, $max_val) + $this->DFS($node->right, $max_val); 
    }
    public function solve_count_good_nodes_in_binary_tree($root)
    {
        return $this->DFS($root, $root->val);
    }
}

$tree = new TreeNode();
$arr = [3,1,4,3,null,1,5];
$root = $tree->insert_level_order($arr);
echo $tree->solve_count_good_nodes_in_binary_tree($root);