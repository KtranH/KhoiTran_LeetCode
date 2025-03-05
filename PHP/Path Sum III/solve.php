<?php 

/*Example 1:


Input: root = [10,5,-3,3,2,null,11,3,-2,null,1], targetSum = 8
Output: 3
Explanation: The paths that sum to 8 are shown.
Example 2:

Input: root = [5,4,8,11,null,13,4,7,2,null,null,5,1], targetSum = 22
Output: 3*/

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
    function __construct($root = null) {
        $this->root = $root;
    }
    public function insert_level_order($arr)
    {
        if(count($arr) == 0)
            return null;
        $this->root = new Node($arr[0]);
        $queue = [];
        array_push($queue, $this->root);
        $i = 1;
        while($i < count($arr) && count($queue) > 0)
        {
            $node = array_shift($queue);
            if($arr[$i] != null)
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
    public function DFS($root, $currentSum, $targetSum, &$hashMap_val)
    {
        if($root === null)
            return 0;
        $currentSum += $root->val;
        $count = ($hashMap_val[$currentSum - $targetSum] ?? 0);
        $hashMap_val[$currentSum] = ($hashMap_val[$currentSum] ?? 0) + 1;
        $count += $this->DFS($root->left, $currentSum, $targetSum, $hashMap_val);
        $count += $this->DFS($root->right, $currentSum, $targetSum, $hashMap_val);
        $hashMap_val[$currentSum] -= 1;
        return $count;
    }
    public function solve_path_sum_iii($root, $targetSum)
    {
        $hashMap_val = [0 => 1];
        return $this->DFS($root, 0, $targetSum, $hashMap_val);
    }
}

$tree = new TreeNode();

$arr = [10,5,-3,3,2,null,11,3,-2,null,1];

$root = $tree->insert_level_order($arr);

echo $tree->solve_path_sum_iii($root, 3); // 3