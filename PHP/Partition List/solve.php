<?php

/*
Example 1:

Input: head = [1,4,3,2,5,2], x = 3
Output: [1,2,2,4,3,5]
Example 2:

Input: head = [2,1], x = 2
Output: [1,2]
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
    public function solve_partition_list(ListNode $Head, $x)
    {
        if($Head == null || $Head->next == null)
        {
            return $Head;
        }
        
        $before_head = new ListNode(0);
        $after_head = new ListNode(0);
        
        $before = $before_head;
        $after = $after_head;
        
        while($Head != null)
        {
            if($Head->val < $x)
            {
                $before->next = $Head;
                $before = $before->next;
            }
            else
            {
                $after->next = $Head;
                $after = $after->next;
            }
            $Head = $Head->next;
        }
        $after->next = null;
        $before->next = $after_head->next;
        return $before_head->next;
    }
}

$head = new ListNode(1);
$head->next = new ListNode(4);
$head->next->next = new ListNode(3);
$head->next->next->next = new ListNode(2);
$head->next->next->next->next = new ListNode(5);
$head->next->next->next->next->next = new ListNode(2);

print_r($head->solve_partition_list($head, 3));
