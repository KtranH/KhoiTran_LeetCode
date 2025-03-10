<?php 
/*Example 1:

Input: root = [1,2,3,null,5,null,4]

Output: [1,3,4]

Explanation:



Example 2:

Input: root = [1,2,3,4,null,null,null,5]

Output: [1,3,4,5]

Explanation:



Example 3:

Input: root = [1,null,3]

Output: [1,3]

Example 4:

Input: root = []

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
    public function insert_level_order($data)
    {
        if(!$data)
        {
            return null;
        }
        $this->root = new Node($data[0]);
        $queue = [$this->root];
        $i = 1;
        while($queue)
        {
            $node = array_shift($queue);
            if($i < count($data) && $data[$i])
            {
                $node->left = new Node($data[$i]);
                $queue[] = $node->left;
            }
            $i++;
            if($i < count($data) && $data[$i])
            {
                $node->right = new Node($data[$i]);
                $queue[] = $node->right;
            }
            $i++;
        }
        return $this->root;
    }
    public function solve_binary_tree_right_side_view($root)
    {
        if($root == null)
        {
            return [];
        }
        $queue = [$root];
        $result = [];
        while(count($queue) > 0)
        {
            $level_size = count($queue);
            for($i = 0; $i < $level_size; $i++)
            {
                $node = array_shift($queue);
                if($i == $level_size - 1)
                {
                    $result[] = $node->val;
                }
                if($node->left)
                {
                    $queue[] = $node->left;
                }
                if($node->right)
                {
                    $queue[] = $node->right;
                }
            }
        }
        return $result;
    }
}

$test = new TreeNode();

$root = $test->insert_level_order([1,2,3,null,5,null,4]);

print_r($test->solve_binary_tree_right_side_view($root));
