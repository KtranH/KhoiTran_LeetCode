path = "/home//foo/"

"""
Example 1:

Input: path = "/home//foo/"
Output: "/home/foo"
Explanation: In the canonical path, multiple slashes are replaced by a single one.
Example 2:

Input: path = "/a/./b/../../c/"
Output: "/c"
"""

def solve_simplify_path(path):
    stack = []
    for i in path.split('/'):
        if i == '' or i == '.':
            continue
        elif i == '..':
            if stack:
                stack.pop()
        else:
            stack.append(i)
    return '/' + '/'.join(stack)

print(solve_simplify_path(path))
