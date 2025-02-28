<?php 

/*Example 1:


Input: head = [5,4,2,1]
Output: 6
Explanation:
Nodes 0 and 1 are the twins of nodes 3 and 2, respectively. All have twin sum = 6.
There are no other nodes with twins in the linked list.
Thus, the maximum twin sum of the linked list is 6. 
Example 2:


Input: head = [4,2,2,3]
Output: 7
Explanation:
The nodes with twins present in this linked list are:
- Node 0 is the twin of node 3 having a twin sum of 4 + 3 = 7.
- Node 1 is the twin of node 2 having a twin sum of 2 + 2 = 4.
Thus, the maximum twin sum of the linked list is max(7, 4) = 7. 
Example 3:


Input: head = [1,100000]
Output: 100001
Explanation:
There is only one node with a twin in the linked list having twin sum of 1 + 100000 = 100001.*/

class Node
{
    public $val;
    public $next;
    public function __construct($data)
    {
        $this->val = $data;
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
    public function findMiddle($head)
    {
        $slow = $head;
        $fast = $head;
        while ($fast != null && $fast->next != null) {
            $slow = $slow->next;
            $fast = $fast->next->next;
        }
        return $slow;
    }
    public function reverse($node)
    {
        $prev = null;
        $current = $node;
        while ($current != null) {
            $next = $current->next;
            $current->next = $prev;
            $prev = $current;
            $current = $next;
        }
        return $prev;
    }
    public function solve_maximum_twin_sum_of_a_linked_list()
    {
        $first = $this->head;
        $middle = $this->findMiddle($this->head);
        $middle = $this->reverse($middle);
        $max = 0;
        while ($middle != null) {
            $temp = $first->val + $middle->val;
            if($max < $temp) {
                $max = $temp;
            }
            $first = $first->next;
            $middle = $middle->next;
        }
        return $max;
    }
}

$list = new ListNode();
$list->append(5);
$list->append(4);
$list->append(2);
$list->append(1);
echo $list->solve_maximum_twin_sum_of_a_linked_list();