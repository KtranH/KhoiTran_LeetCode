<?php

/*
Example 1:

Input: root = [1,2,3,4,5,null,7]
Output: [1,#,2,3,#,4,5,7,#]
Explanation: Given the above binary tree (Figure A), your function should populate each next pointer to point to its next right node, just like in Figure B. The serialized output is in level order as connected by the next pointers, with '#' signifying the end of each level.
Example 2:

Input: root = []
Output: []
*/

class TreeNode
{
    public $val;
    public $left;
    public $right;
    public $next;
    public function __construct($val = 0, $left = null, $right = null, $next = null)
    {
        $this->val = $val;
        $this->left = $left;
        $this->right = $right;
        $this->next = $next;
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
            if($values[$i] != null)
            {
                $current->left = new TreeNode($values[$i]);
                $queue[] = $current->left;
            }
            $i++;
            if($i < count($values) && $values[$i] != null)
            {
                $current->right = new TreeNode($values[$i]);
                $queue[] = $current->right;
            }
            $i++;
        }
        return $this;
    }
    public function solve_populating_next_right_pointers_in_each_node_ii($root)
    {
        $result = $root;
        while($root != null)
        {
            $dummy = new TreeNode(0);
            $tail = $dummy;
            $curr = $root;
            while($curr != null)
            {
                if($curr->left != null)
                {
                    $tail->next = $curr->left;
                    $tail = $tail->next;
                }
                if($curr->right != null)
                {
                    $tail->next = $curr->right;
                    $tail = $tail->next;
                }
                $curr = $curr->next;
            }
            $root = $dummy->next;
        }
        return $result;
    }
}

$root = new TreeNode();
$root->insert_level_order([1,2,3,4,5,null,7]);
$root->solve_populating_next_right_pointers_in_each_node_ii($root);
print_r($root);
