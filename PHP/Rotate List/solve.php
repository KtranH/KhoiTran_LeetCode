<?php

/*
Example 1:

Input: head = [1,2,3,4,5], k = 2
Output: [4,5,1,2,3]
Example 2:

Input: head = [0,1,2], k = 4
Output: [2,0,1]
*/

class ListNode
{
    public $val = 0;
    public $next = null;
    public function __construct($val = 0, $next = null)
    {
        $this->val = $val;
        $this->next = $next;
    }
    public function solve_rotate_list($head, $k)
    {
        if($head == null || $head->next == null || $k == 0) {
            return $head;
        }
        
        $length = 1;
        $tail = $head;
        while($tail->next != null) {
            $length++;
            $tail = $tail->next;
        }
        
        $k = $k % $length;
        if($k == 0) {
            return $head;
        }
        
        $stepsToNewHead = $length - $k;
        $prev = null;
        $current = $head;
        for($i = 0; $i < $stepsToNewHead; $i++) {
            $prev = $current;
            $current = $current->next;
        }
        
        $prev->next = null;
        $tail->next = $head;
        $head = $current;
        
        return $head;
    }
}

$head = [1,2,3,4,5];
$k = 2;
$listNode = new ListNode();
echo $listNode->solve_rotate_list($head, $k);
