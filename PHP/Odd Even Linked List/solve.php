<?php 

/*Example 1:


Input: head = [1,2,3,4,5]
Output: [1,3,5,2,4]
Example 2:


Input: head = [2,1,3,5,6,4,7]
Output: [2,3,6,7,1,5,4]*/

class Node
{
    public $val = 0;
    public $next = null;
    function __construct($data)
    {
        $this->val = $data;
        $this->next = null;
    }
}
class ListNode
{
    public $head = null;
    function append($data)
    {
        $new_node = new Node($data);
        if ($this->head == null) {
            $this->head = $new_node;
            return;
        }
        $current = $this->head;
        while ($current->next!= null) {
            $current = $current->next;
        }
        $current->next = $new_node;
    }
    function printList()
    {
        $current = $this->head;
        while ($current!= null) {
            echo $current->val. " ";
            $current = $current->next;
        }
        echo "\n";
    }
    function solve_odd_even_linked_list()
    {
        $odd_head = null;
        $even_head = null;
        $odd = null;
        $even = null;
        $is_even = false;
        $node = $this->head;
        while ($node!= null) {
            if($is_even)
            {
                if(!$even_head)
                {
                    $even_head = $node;
                    $even = $even_head;
                }
                else
                {
                    if($even)
                    {
                        $even->next = $node;
                        $even = $node;
                    }
                }
            }
            else
            {
                if(!$odd_head)
                {
                    $odd_head = $node;
                    $odd = $odd_head;
                }
                else
                {
                    if($odd)
                    {
                        $odd->next = $node;
                        $odd = $node;
                    }
                }
            }
            $is_even =!$is_even;
            $node = $node->next;
        }
        if($odd) $odd->next = $even_head;
        if($even) $even->next = null;
        if($odd_head) $this->head = $odd_head;
        else $this->head = $even_head;
    }
}

$test = new ListNode();
$test->append(1);
$test->append(2);
$test->append(3);
$test->append(4);
$test->append(5);
$test->solve_odd_even_linked_list();
$test->printList();