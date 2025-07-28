<?php

/*
Example 1:

Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]
Example 2:

Input: head = [1], n = 1
Output: []
Example 3:

Input: head = [1,2], n = 1
Output: [1]
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
    public function solve_remove_nth_node_from_end_of_list($head, $n)
    {
        if($head == null || $n <= 0)
        {
            return $head;
        }
        
        $dummy = new ListNode(0);
        $dummy->next = $head;
        $first = $dummy;
        $second = $dummy;

        for($i = 0; $i < $n; $i++)
        {
            $first = $first->next;
        }

        while($first->next != null)
        {
            $first = $first->next;
            $second = $second->next;
        }

        $second->next = $second->next->next;
        return $dummy->next;
    }
}

$head = new ListNode(1);
$head->next = new ListNode(2);
$head->next->next = new ListNode(3);
$head->next->next->next = new ListNode(4);
$head->next->next->next->next = new ListNode(5);

$n = 2;

$result = $head->solve_remove_nth_node_from_end_of_list($head, $n);

while($result != null)
{
    echo $result->val . " ";
    $result = $result->next;
}
