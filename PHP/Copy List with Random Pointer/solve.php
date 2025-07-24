<?php

/*
Input: head = [[7,null],[13,0],[11,4],[10,2],[1,0]]
Output: [[7,null],[13,0],[11,4],[10,2],[1,0]]
*/

class Node
{
    public $val = 0;
    public $next = null;
    public $random = null;
    function __construct($val = 0, $next = null, $random = null)
    {
        $this->val = $val;
        $this->next = $next;
        $this->random = $random;
    }
    function solve_copyRandomList($head)
    {
        if ($head == null)
        {
            return null;
        }
        
        $curr = $head;
        while ($curr != null)
        {
            $copy = new Node($curr->val);
            $copy->next = $curr->next;
            $curr->next = $copy;
            $curr = $copy->next;
        }

        $curr = $head;
        while ($curr != null)
        {
            if ($curr->random != null)
            {
                $curr->next->random = $curr->random->next;
            }
            $curr = $curr->next->next;
        }

        $pseudo_head = new Node(0);
        $copy_curr = $pseudo_head;
        $curr = $head;

        while ($curr != null)
        {
            $copy = $curr->next;
            $copy_curr->next = $copy;
            $copy_curr = $copy;

            $curr->next = $copy->next;
            $curr = $curr->next;
        }

        return $pseudo_head->next;
    }
}