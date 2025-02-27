<?php

/*Example 1:


Input: head = [1,2,3,4,5]
Output: [5,4,3,2,1]
Example 2:


Input: head = [1,2]
Output: [2,1]
Example 3:

Input: head = []
Output: []*/

class Node
{
    public $val;
    public $next;
    function __construct($val)
    {
        $this->val = $val;
        $this->next = null;
    }
}
class ListNode
{
    public $head = null;
    public function append($value)
    {
        $new_node = new Node($value);
        if ($this->head == null) {
            $this->head = $new_node;
            return;
        }
        $current = $this->head;
        while ($current->next != null) {
            $current = $current->next;
        }
        $current->next = $new_node;
    }
    public function printList()
    {
        $current = $this->head;
        while ($current != null) {
            echo $current->val . " ";
            $current = $current->next;
        }
        echo "\n";
    }
    public function reverse()
    {
        $prev = null;
        $current = $this->head;
        while ($current != null) {
            $next = $current->next;
            $current->next = $prev;
            $prev = $current;
            $current = $next;
        }
        $this->head = $prev;
    }
}

$list = new ListNode();
$list->append(1);
$list->append(2);
$list->append(3);
$list->reverse();
$list->printList();