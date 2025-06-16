s = "abcabcbb"

"""
Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
"""

def solve_longest_substring_without_repeating_characters(s):
    n = len(s)
    left = 0
    right = 0
    max_length = 0
    char_set = set()
    while right < n:
        if s[right] not in char_set:
            char_set.add(s[right])
            right += 1
            temp = right - left
            if temp > max_length:
                max_length = temp
        else:
            char_set.remove(s[left])
            left += 1
    return max_length

print(solve_longest_substring_without_repeating_characters(s))
