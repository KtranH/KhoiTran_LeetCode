<?php

/*
Example 1:


Input
["BSTIterator", "next", "next", "hasNext", "next", "hasNext", "next", "hasNext", "next", "hasNext"]
[[[7, 3, 15, null, null, 9, 20]], [], [], [], [], [], [], [], [], []]
Output
[null, 3, 7, true, 9, true, 15, true, 20, false]

Explanation
BSTIterator bSTIterator = new BSTIterator([7, 3, 15, null, null, 9, 20]);
bSTIterator.next();    // return 3
bSTIterator.next();    // return 7
bSTIterator.hasNext(); // return True
bSTIterator.next();    // return 9
bSTIterator.hasNext(); // return True
bSTIterator.next();    // return 15
bSTIterator.hasNext(); // return True
bSTIterator.next();    // return 20
bSTIterator.hasNext(); // return False
*/

class TreeNode
{
    public $val = 0;
    public $left = null;
    public $right = null;
    public $stack = [];
    public function _push_left($node)
    {
        while ($node)
        {
            array_push($this->stack, $node);
            $node = $node->left;
        }
    }
    public function next()
    {
        $node = array_pop($this->stack);
        $this->_push_left($node->right);
        return $node->val;
    }
    public function hasNext()
    {
        return count($this->stack) > 0;
    }
}

$root = new TreeNode();
$root->insert_level_order([7, 3, 15, null, null, 9, 20]);
while ($root->hasNext())
{
    echo $root->next() . " ";
}
