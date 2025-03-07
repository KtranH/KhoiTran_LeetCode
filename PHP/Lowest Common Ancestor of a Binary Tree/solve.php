<?php 

/*Example 1:


Input: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 1
Output: 3
Explanation: The LCA of nodes 5 and 1 is 3.
Example 2:


Input: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 4
Output: 5
Explanation: The LCA of nodes 5 and 4 is 5, since a node can be a descendant of itself according to the LCA definition.
Example 3:

Input: root = [1,2], p = 1, q = 2
Output: 1*/

class Node
{
    public $val = null;
    public $left = null;
    public $right = null;
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
    public function insert_level_order($arr)
    {
        if(count($arr) == 0)
        {
            return null;
        }
        $this->root = new Node($arr[0]);
        $queue = [];
        array_push($queue, $this->root);
        $i = 1;
        while($i < count($arr) && count($queue) > 0)
        {
            $node = array_shift($queue);
            if($i < count($arr) && $arr[$i] != null)
            {
                $node->left = new Node($arr[$i]);
                array_push($queue, $node->left);
            }
            $i++;
            if($i < count($arr) && $arr[$i] != null)
            {
                $node->right = new Node($arr[$i]);
                array_push($queue, $node->right);
            }
            $i++;
        }
        return $this->root;
    }
    public function solve_lowest_common_ancestor_of_a_binary_tree($root, $p, $q)
    {
        if($root == null)
        {
            return null;
        }
        if($root->val == $p || $root->val == $q)
        {
            return $root;
        }
        $left = $this->solve_lowest_common_ancestor_of_a_binary_tree($root->left, $p, $q);
        $right = $this->solve_lowest_common_ancestor_of_a_binary_tree($root->right, $p, $q);
        if($left!= null && $right!= null)
        {
            return $root;
        }
        return $left!= null? $left : $right;
    }
}

$tree = new TreeNode();

$arr = [3,5,1,6,2,0,8,null,null,7,4];

$root = $tree->insert_level_order($arr);

$p = 5;
$q = 1;

echo $tree->solve_lowest_common_ancestor_of_a_binary_tree($root, $p, $q)->val; // 3