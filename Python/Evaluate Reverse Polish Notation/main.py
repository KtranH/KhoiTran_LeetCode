tokens = ["2", "1", "+", "3", "*"]

"""
Example 1:

Input: tokens = ["2","1","+","3","*"]
Output: 9
Explanation: ((2 + 1) * 3) = 9
Example 2:

Input: tokens = ["4","13","5","/","+"]
Output: 6
Explanation: (4 + (13 / 5)) = 6
Example 3:

Input: tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]
Output: 22
"""

def solve_ReversePolishNotation(tokens: list[str]) -> int:
    stacks = []
    for token in tokens:
        if token == "+":
            a, b = stacks.pop(), stacks.pop()
            stacks.append(a + b)
        elif token == "-":
            a, b = stacks.pop(), stacks.pop()
            stacks.append(b - a)
        elif token == "*":
            a, b = stacks.pop(), stacks.pop()
            stacks.append(a * b)
        elif token == "/":
            a, b = stacks.pop(), stacks.pop()
            stacks.append(int(b / a))
        else:
            stacks.append(int(token))
    return stacks.pop()

print(solve_ReversePolishNotation(tokens))
