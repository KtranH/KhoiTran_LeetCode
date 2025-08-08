<?php

/*
Example 1:

Input: inorder = [9,3,15,20,7], postorder = [9,15,7,20,3]
Output: [3,9,20,null,null,15,7]
Example 2:

Input: inorder = [-1], postorder = [-1]
Output: [-1]
 
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
        if (count($values) == 0)
            return null;
        $this->val = $values[0];
        $queue = [$this];
        $i = 1;
        while ($i < count($values) && count($queue) > 0)
        {
            $current = array_shift($queue);
            if ($values[$i] != null)
            {
                $current->left = new TreeNode($values[$i]);
                $queue[] = $current->left;
            }
            $i++;
            if ($i < count($values) && $values[$i] != null)
            {
                $current->right = new TreeNode($values[$i]);
                $queue[] = $current->right;
            }
            $i++;
        }
        return $this;
    }
    public function solve_construct_binary_tree_from_inorder_and_postorder_traversal($inorder, $postorder)
    {
        if (count($inorder) == 0 || count($postorder) == 0)
            return null;
        $root = new TreeNode($postorder[count($postorder) - 1]);
        $i = array_search($postorder[count($postorder) - 1], $inorder);
        $leftInorder = array_slice($inorder, 0, $i);
        $rightInorder = array_slice($inorder, $i + 1);
        $leftPostorder = array_slice($postorder, 0, $i);
        $rightPostorder = array_slice($postorder, $i, count($postorder) - $i - 1);
        $root->left = $this->solve_construct_binary_tree_from_inorder_and_postorder_traversal($leftInorder, $leftPostorder);
        $root->right = $this->solve_construct_binary_tree_from_inorder_and_postorder_traversal($rightInorder, $rightPostorder);
        return $root;
    }
}

$root = new TreeNode();
$root->insert_level_order([3, 9, 20, 15, 7]);
$result = $root->solve_construct_binary_tree_from_inorder_and_postorder_traversal([9, 3, 15, 20, 7], [9, 15, 7, 20, 3]);
echo $result->val;