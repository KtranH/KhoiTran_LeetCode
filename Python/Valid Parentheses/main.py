s = "()[]{}"

"""
Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
"""

def solve_valid_parentheses(s):
    stack = []
    for char in s:
        if char == '(' or char == '[' or char == '{':
            stack.append(char)
        elif char == ')' or char == ']' or char == '}':
            if not stack:
                return False
            if char == ')' and stack[-1] != '(':
                return False
            if char == ']' and stack[-1] != '[':
                return False
            if char == '}' and stack[-1] != '{':
                return False
            stack.pop()
    return not stack

print(solve_valid_parentheses(s))
