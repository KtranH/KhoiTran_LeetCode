pattern = "abba"
s = "dog cat cat dog"

"""
Example 1:

Input: pattern = "abba", s = "dog cat cat dog"
Output: true
Example 2:

Input: pattern = "abba", s = "dog cat cat fish"
Output: false
Example 3:

Input: pattern = "aaaa", s = "dog cat cat dog"
Output: false
Example 4:

Input: pattern = "abba", s = "dog dog dog dog"
Output: false
"""

def solve_word_pattern(pattern, s):
    s = s.split(" ")
    if len(pattern) != len(s):
        return False
    pattern_map = {}
    for i in range(len(pattern)):
        if pattern[i] not in pattern_map:
            if s[i] in pattern_map.values():
                return False
            pattern_map[pattern[i]] = s[i]
        else:
            if pattern_map[pattern[i]] != s[i]:
                return False
    return True

print(solve_word_pattern(pattern, s))
