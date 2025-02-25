<?php
/*Example 1:


Input: head = [1,3,4,7,1,2,6]
Output: [1,3,4,1,2,6]
Explanation:
The above figure represents the given linked list. The indices of the nodes are written below.
Since n = 7, node 3 with value 7 is the middle node, which is marked in red.
We return the new list after removing this node. 
Example 2:


Input: head = [1,2,3,4]
Output: [1,2,4]
Explanation:
The above figure represents the given linked list.
For n = 4, node 2 with value 3 is the middle node, which is marked in red.
Example 3:


Input: head = [2,1]
Output: [2]
Explanation:
The above figure represents the given linked list.
For n = 2, node 1 with value 1 is the middle node, which is marked in red.
Node 0 with value 2 is the only node remaining after removing node 1.*/
class Node
{
    public $value;
    public $next;
    public function __construct($value)
    {
        $this->value = $value;
        $this->next = null;
    }
}
class LinkedList
{
    public $head = null;
    public function Append($data)
    {
       $newNode = new Node($data);
       if($this->head == null) {
        $this->head = $newNode;
        return;
       }
       $current = $this->head;
       while($current->next!= null) {
        $current = $current->next;
       }
       $current->next = $newNode; 
    }
    public function PrintList()
    {
        $current = $this->head;
        while($current!= null) {
            echo $current->value."->";
            $current = $current->next;
        }
        echo "NULL\n";
    }
    public function Delete_Middle()
    {
        if($this->head == null || $this->head->next == null) return;   
        $prev = null;
        $slow = $this->head;
        $fast = $this->head;
        while($fast!= null && $fast->next!= null) {
            $prev = $slow;
            $slow = $slow->next;
            $fast = $fast->next->next;
        }
        $prev->next = $slow->next;
    }
}

$list = new LinkedList();

$list->Append(1);

$list->Append(2);

$list->Append(3);

$list->Delete_Middle();

$list->PrintList();