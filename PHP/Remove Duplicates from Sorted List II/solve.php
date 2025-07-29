<?php

/*
Example 1:


Input: head = [1,2,3,3,4,4,5]
Output: [1,2,5]
Example 2:


Input: head = [1,1,1,2,3]
Output: [2,3]
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
    public function solve_remove_duplicates_from_sorted_list_ii($head)
    {
        if (!$head) return null;
        $dummy = new ListNode(0);
        $dummy->next = $head;
        $prev = $dummy;
        while ($prev->next && $prev->next->next) {
            if ($prev->next->val === $prev->next->next->val) {
                $dup_val = $prev->next->val;
                while ($prev->next && $prev->next->val === $dup_val) {
                    $prev->next = $prev->next->next;
                }
            } else {
                $prev = $prev->next;
            }
        }
        return $dummy->next;
    }
}   

$head = [1,2,3,3,4,4,5];
print_r(ListNode::solve_remove_duplicates_from_sorted_list_ii($head));
