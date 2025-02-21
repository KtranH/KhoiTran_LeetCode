"""
Example 1:

Input: s = "3[a]2[bc]"
Output: "aaabcbc"
Example 2:

Input: s = "3[a2[c]]"
Output: "accaccacc"
Example 3:

Input: s = "2[abc]3[cd]ef"
Output: "abcabccdcdcdef"
"""

s = "3[a]2[bc]"

def solve_decode_string(s):
    current_string = ""
    current_num = 0
    stack = []
    
    for char in s:
        if char.isdigit():
            current_num = current_num * 10 + int(char)
        elif char == "[":
            stack.append((current_num, current_string))
            current_string = ""
            current_num = 0
        elif char == "]":
            num, prev_string = stack.pop()
            current_string = prev_string + current_string * num
        else:
            current_string += char
    return current_string

print(solve_decode_string(s))