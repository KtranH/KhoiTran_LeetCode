<?php

/*
Example 1:

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
*/

$l1 = [2,4,3];
$l2 = [5,6,4];

class LinkedList
{
    public $val;
    public $next;
    public function __construct($val = 0, $next = null)
    {
        $this->val = $val;
        $this->next = $next;
    }   
    public function solve_add_two_numbers($l1, $l2)
    {
        $dummy_head = new LinkedList(0);
        $current = $dummy_head;
        $carry = 0;
        while ($l1 != null || $l2 != null)
        {
            $x = ($l1 != null) ? $l1->val : 0;
            $y = ($l2 != null) ? $l2->val : 0;
            $sum = $carry + $x + $y;
            $carry = floor($sum / 10);
            $current->next = new LinkedList($sum % 10);
            $current = $current->next;
            if ($l1 != null) $l1 = $l1->next;
            if ($l2 != null) $l2 = $l2->next;
        }
        if ($carry > 0)
        {
            $current->next = new LinkedList($carry);
        }
        return $dummy_head->next;
    }
}

$l1 = new LinkedList();
$l2 = new LinkedList();
$result = $l1->solve_add_two_numbers($l1, $l2);
while ($result != null)
{
    echo $result->val . " ";
    $result = $result->next;
}
