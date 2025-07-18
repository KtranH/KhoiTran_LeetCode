<?php

/*
Example 1:

Input: head = [3,2,0,-4], pos = 1
Output: true
Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).
Example 2:

Input: head = [1,2], pos = 0
Output: true
Explanation: There is a cycle in the linked list, where the tail connects to the 0th node.
Example 3:

Input: head = [1], pos = -1
Output: false
Explanation: There is no cycle in the linked list.
*/

class Node
{
    public $val;
    public $next;
    public function __construct($val)
    {
        $this->val = $val;
        $this->next = null;
    }
}
class LinkedList
{
    public $head;
    public function __construct()
    {
        $this->head = null;
    }
    // Thêm vào cuối danh sách
    public function append($val)
    {
        $newNode = new Node($val);
        if (!$this->head)
        {
            $this->head = $newNode;
            return;
        }
        $current = $this->head;
        while ($current->next)
        {
            $current = $current->next;
        }
        $current->next = $newNode;
    }
    // In ra danh sách
    public function printList()
    {
        $current = $this->head;
        while ($current)
        {
            echo $current->val . " ";
            $current = $current->next;
        }
        echo "\n";
    }
    // Kiểm tra xem danh sách có chứa chu kỳ không
    public function hasCycle()
    {
        $slow = $this->head;
        $fast = $this->head;
        while ($fast && $fast->next)
        {
            $slow = $slow->next;
            $fast = $fast->next->next;
            if ($slow == $fast)
            {
                return true;
            }
        }
        return false;
    }
}

$list = new LinkedList();
$list->append(1);
$list->append(2);
$list->append(3);
$list->append(4);
$list->append(5);
$list->printList();
echo $list->hasCycle();