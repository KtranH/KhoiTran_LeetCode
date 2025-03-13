<?php 
/*Example 1:


Input: root = [5,3,6,2,4,null,7], key = 3
Output: [5,4,6,2,null,null,7]
Explanation: Given key to delete is 3. So we find the node with value 3 and delete it.
One valid answer is [5,4,6,2,null,null,7], shown in the above BST.
Please notice that another valid answer is [5,2,6,null,4,null,7] and it's also accepted.

Example 2:

Input: root = [5,3,6,2,4,null,7], key = 0
Output: [5,3,6,2,4,null,7]
Explanation: The tree does not contain a node with value = 0.
Example 3:

Input: root = [], key = 0
Output: []*/

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
    public function insert($val)
    {
        if($this->root == null)
        {
            $this->root = new Node($val);
        }
        else
        {
            $this->_insert_recursive($this->root, $val);
        }
    }
    public function _insert_recursive($root, $val)
    {
        if($root->val > $val)
        {
            if($root->left == null)
            {
                $root->left = new Node($val);
            }
            else
            {
                $this->_insert_recursive($root->left, $val);
            }
        }
        else
        {
            if($root->right == null)
            {
                $root->right = new Node($val);
            }
            else
            {
                $this->_insert_recursive($root->right, $val);
            }
        }
    }
    public function find_successor($root)
    {
        while($root->left)
        {
            $root = $root->left;
        }
        return $root->val;
    }
    public function solve_delete_node_in_a_bst($root, $key)
    {
        if($root == null)
        {
            return null;
        }
        if($root->val > $key)
        {
            $root->left = $this->solve_delete_node_in_a_bst($root->left, $key);
        }
        else if($root->val < $key)
        {
            $root->right = $this->solve_delete_node_in_a_bst($root->right, $key);
        }
        else
        {
            if($root->left == null)
            {
                return $root->right;
            }
            else if($root->right == null)
            {
                return $root->left;
            }
            else
            {
                $successor = $this->find_successor($root->right);
                $root->val = $successor;
                $root->right = $this->solve_delete_node_in_a_bst($root->right, $successor);
            }
        }
        return $root;   
    }
}

$test = new TreeNode();
$test->insert(5);
$test->insert(3);
$test->insert(6);
$test->insert(2);
$test->insert(4);
$test->insert(7);
$test->solve_delete_node_in_a_bst($test->root, 3);