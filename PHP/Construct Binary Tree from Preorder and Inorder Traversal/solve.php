<?php

/*
Example 1:

Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
Output: [3,9,20,null,null,15,7]
Example 2:

Input: preorder = [-1], inorder = [-1]
Output: [-1]

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
        if(count($values) == 0)
            return null;
        $this->val = $values[0];
        $queue = [$this];
        $i = 1;
        while($i < count($values) && count($queue) > 0)
        {
            $current = array_shift($queue);
            if($values[$i] !== null)
            {
                $current->left = new TreeNode($values[$i]);
                $queue[] = $current->left;
            }
            $i++;
            if($i < count($values) && $values[$i] !== null)
            {
                $current->right = new TreeNode($values[$i]);
                $queue[] = $current->right;
            }
            $i++;
        }
        return $this;
    }
    public function construct_binary_tree_from_preorder_and_inorder_traversal($preorder, $inorder)
    {
        if(count($preorder) == 0 || count($inorder) == 0)
            return null;
        $root = new TreeNode($preorder[0]);
        $i = array_search($preorder[0], $inorder);
        $left_inorder = array_slice($inorder, 0, $i);
        $right_inorder = array_slice($inorder, $i + 1);
        $left_preorder = array_slice($preorder, 1, $i + 1);
        $right_preorder = array_slice($preorder, $i + 1);
        $root->left = $this->construct_binary_tree_from_preorder_and_inorder_traversal($left_preorder, $left_inorder);
        $root->right = $this->construct_binary_tree_from_preorder_and_inorder_traversal($right_preorder, $right_inorder);
        return $root;
    }
}

$root = new TreeNode();
$root->insert_level_order([3,9,20,15,7]);
echo $root->construct_binary_tree_from_preorder_and_inorder_traversal([3,9,20,15,7], [9,3,15,20,7]);
