s = "anagram"
t = "nagaram"

"""
Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false
"""

def solve_vaild_anagram(s, t):
    s_map = {}
    for i in s:
        if i in s_map:
            s_map[i] += 1
        else:
            s_map[i] = 1
    t_map = {}
    for i in t:
        if i in t_map:
            t_map[i] += 1
        else:
            t_map[i] = 1
    return s_map == t_map

print(solve_vaild_anagram(s, t))
