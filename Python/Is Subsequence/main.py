"""
Example 1:

Input: s = "abc", t = "ahbgdc"
Output: true
Example 2:

Input: s = "axc", t = "ahbgdc"
Output: false
"""

s = "axc"
t = "ahbgdc"

def solve_is_subsequence(s, t):
    check_index = 0
    count = 0
    if len(s) == 0:
        return True
    for i in range(len(t)):
        if t[i] == s[check_index]:
            check_index += 1
            count += 1
        if count == len(s):
            return True
    return False

print(solve_is_subsequence(s, t))
