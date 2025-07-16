<?php

/*
Example 1:

Input: val = -2
Output: None
Explanation: The minimum stack is initialized with the value -2.
Example 2:

Input: val = 0
Output: None
Explanation: The minimum stack is initialized with the value 0.
Example 3:

Input: val = -3
Output: None
Explanation: The minimum stack is initialized with the value -3.
*/

class MinStack {
    private $stack = [];
    private $minStack = [];
    
    public function __construct() {
        $this->stack = [];
        $this->minStack = [];  
    }
    
    public function push($val) {
        array_push($this->stack, $val);
        if (empty($this->minStack) || $val <= end($this->minStack)) {
            array_push($this->minStack, $val);
        }
    }
    
    public function pop() {
        $val = array_pop($this->stack);
        if ($val == end($this->minStack)) {
            array_pop($this->minStack);
        }
    }
    
    public function top() {
        return end($this->stack);
    }
    
    public function getMin() {
        return end($this->minStack);
    }
}

$obj = new MinStack();
$obj->push(-2);
$obj->push(0);
$obj->push(-3);
echo $obj->getMin();
$obj->pop();
echo $obj->top();
echo $obj->getMin();
