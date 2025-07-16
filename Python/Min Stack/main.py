"""
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
"""

class MinStack:
    def __init__(self):
        self.stack = []
        self.min_stack = []
    def push(self, val: int) -> None:
        self.stack.append(val)
        if not self.min_stack or val <= self.min_stack[-1]:
            self.min_stack.append(val)
    def pop(self) -> None:
        if self.stack[-1] == self.min_stack[-1]:
            self.min_stack.pop()
        self.stack.pop()
    def top(self) -> int:
        return self.stack[-1]
    def getMin(self) -> int:
        return self.min_stack[-1]

obj = MinStack()
obj.push(-2)
obj.push(0)
obj.push(-3)
obj.pop()
param_3 = obj.top()
param_4 = obj.getMin()
print(param_3)
print(param_4)