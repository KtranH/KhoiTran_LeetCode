s = "Hello World"

"""
Example 1:

Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.
Example 2:

Input: s = "   fly me   to   the moon  "
Output: 4
Explanation: The last word is "moon" with length 4.
Example 3:

Input: s = "luffy is still joyboy"
Output: 6
Explanation: The last word is "joyboy" with length 6.
"""

def solve_length_of_last_word(s):
    s = s.strip()
    return len(s.split(" ")[-1])

print(solve_length_of_last_word(s))