<?php 
/*Example 1:


Input: root = [1,null,1,1,1,null,null,1,1,null,1,null,null,null,1]
Output: 3
Explanation: Longest ZigZag path in blue nodes (right -> left -> right).
Example 2:


Input: root = [1,1,1,null,1,null,null,1,1,null,1]
Output: 4
Explanation: Longest ZigZag path in blue nodes (left -> right -> left -> right).
Example 3:

Input: root = [1]
Output: 0*/
 

class Node
{
    public $val = null;
    public $left = null;
    public $right = null;
    function __construct($value)
    {
        $this->val = $value;
        $this->left = null;
        $this->right = null;
    }
}
class TreeNode
{
    public $root = null;
    public $max_length = 0;
    function __construct()
    {
        $this->root = null;
        $this->max_length = 0;
    }
    public function insert_level_order($val)
    {
        if(count($val) == 0)
        {
            return null;
        }
        $this->root = new Node($val[0]);
        $queue = array();
        array_push($queue, $this->root);
        $i = 1;
        while($i < count($val) && count($queue) > 0)
        {
            $current = array_shift($queue);
            if($val[$i]!=null)
            {
                $current->left = new Node($val[$i]);
                array_push($queue, $current->left);
            }
            $i++;
            if($i < count($val) && $val[$i]!== null)
            {
                $current->right = new Node($val[$i]);
                array_push($queue, $current->right);
            }
            $i++;
        }
        return $this->root;
    }
    public function DFS($node, $length, $direction)
    {
        if($node == null)
        {
            return;
        }
        if($length > $this->max_length)
        {
            $this->max_length = $length;
        }
        if($direction == "left")
        {
            $this->DFS($node->right, $length + 1, "right");
            $this->DFS($node->left, 1, "left");
        }
        else
        {
            $this->DFS($node->left, $length + 1, "left");
            $this->DFS($node->right, 1, "right");   
        }
    }
    public function solve_longest_zigzag_path_in_a_binary_tree($root)
    {
        $this->DFS($root, 0, "left");
        $this->DFS($root, 0, "right");   
        return $this->max_length;
    }
}

$tree = new TreeNode();
$tree->insert_level_order([3,9,20,null,null,15,7]);
echo $tree->solve_longest_zigzag_path_in_a_binary_tree($tree->root);