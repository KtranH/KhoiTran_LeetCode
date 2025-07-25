<?php

/*

Example 1:

Input: head = [1,2,3,4,5], left = 2, right = 4
Output: [1,4,3,2,5]

Example 2:

Input: head = [5], left = 1, right = 1
Output: [5]

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
    public function solve_reverse_linked_list_ii($head, $left, $right)
    {
        if ($head == null || $left == $right)
        {
            return $head;
        }

        $dummy = new ListNode(0);
        $dummy->next = $head;
        $prev = $dummy;

        for ($i = 1; $i < $left; $i++)
        {
            $prev = $prev->next;
        }

        $curr = $prev->next;
        $reverse = null;

        for ($i = 0; $i < $right - $left + 1; $i++)
        {
            $next_node = $curr->next;
            $curr->next = $reverse;
            $reverse = $curr;
            $curr = $next_node;
        }

        $prev->next->next = $curr;
        $prev->next = $reverse;
        return $dummy->next;
    }
}   

$head = new ListNode(1);
$head->next = new ListNode(2);
$head->next->next = new ListNode(3);
$head->next->next->next = new ListNode(4);
$head->next->next->next->next = new ListNode(5);

$left = 2;
$right = 4;

$result = $head->solve_reverse_linked_list_ii($head, $left, $right);

while ($result != null)
{
    echo $result->val . " ";
    $result = $result->next;
}
