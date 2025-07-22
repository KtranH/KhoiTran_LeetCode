<?php

/*
Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
*/

class ListNode{
    public $val;
    public $next;
    public function __construct($val = 0, $next = null){
        $this->val = $val;
        $this->next = $next;
    }
}
function mergeTwoLists($list1, $list2){
    $dummy = new ListNode();
    $current = $dummy;
    while($list1 != null && $list2 != null){
        if($list1->val < $list2->val){
            $current->next = $list1;
            $list1 = $list1->next;
        }else{
            $current->next = $list2;
            $list2 = $list2->next;
        }
        $current = $current->next;
    }
    $current->next = $list1 ?? $list2;
    return $dummy->next;
}

$list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
$list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
$result = mergeTwoLists($list1, $list2);
while($result != null){
    echo $result->val;
    $result = $result->next;
}
