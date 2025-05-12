s = "babad"

"""
Example 1:

Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.
Example 2:

Input: s = "cbbd"
Output: "bb"
"""

def expand_from_center(left: int, right: int) -> str:
    while left >= 0 and right < len(s) and s[left] == s[right]:
        left -= 1
        right += 1
    return s[left+1:right]

def solve_longest_palindromic_substring(s):
    result = ""
    for i in range(len(s)):
        odd = expand_from_center(i, i)
        even = expand_from_center(i, i + 1)

        longer = odd if len(odd) > len(even) else even
        if len(longer) > len(result):
            result = longer

    return result

print(solve_longest_palindromic_substring(s))
