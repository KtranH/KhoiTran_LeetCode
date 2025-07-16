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

var MinStack = function() {
    this.stack = [];
    this.minStack = [];
};

MinStack.prototype.push = function(val) {
    this.stack.push(val);
    if (this.minStack.length === 0 || val <= this.minStack[this.minStack.length - 1]) {
        this.minStack.push(val);
    }
};

MinStack.prototype.pop = function() {
    if (this.stack.length === 0) return;
    let val = this.stack.pop();
    if (val === this.minStack[this.minStack.length - 1]) {
        this.minStack.pop();
    }
};

MinStack.prototype.top = function() {
    return this.stack[this.stack.length - 1];
};

MinStack.prototype.getMin = function() {
    return this.minStack[this.minStack.length - 1];
};

let minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
console.log(minStack.getMin());
minStack.pop();
console.log(minStack.top());
console.log(minStack.getMin());
