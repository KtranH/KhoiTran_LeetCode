<?php 
/*Example 1:


Input: root1 = [3,5,1,6,2,9,8,null,null,7,4], root2 = [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]
Output: true
Example 2:


Input: root1 = [1,2,3], root2 = [1,3,2]
Output: false*/
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
        if(count($arr) == 0)
            return null;
        $this->root = new Node($arr[0]);
        $queue = array();
        array_push($queue, $this->root);
        $i = 1;
        while($i < count($arr) && count($queue) > 0)
        {
            $node = array_shift($queue);
            if($arr[$i]!=null)
            {
                $node->left = new Node($arr[$i]);
                array_push($queue, $node->left);
            }
            $i++;
            if($i < count($arr) && $arr[$i]!=null)
            {
                $node->right = new Node($arr[$i]);
                array_push($queue, $node->right);
            }
            $i++;
        }
        return $this->root;
    }
    public function DFS($root)
    {
        if($root == null)
            return array();
        if($root->left == null && $root->right == null)
            return array($root->val);
        return array_merge($this->DFS($root->left), $this->DFS($root->right));
    }
    public function solve_leaf_similar_trees($root1, $root2)
    {
        return $this->DFS($root1) == $this->DFS($root2);
    }
}

$arr1 = array(3,5,1,6,2,9,8,null,null,7,4);
$arr2 = array(3,5,1,6,7,4,2,null,null,null,null,null,null,9,8);
$tree = new TreeNode();
$root1 = $tree->insert_level_order($arr1);
$root2 = $tree->insert_level_order($arr2);
echo $tree->solve_leaf_similar_trees($root1, $root2);