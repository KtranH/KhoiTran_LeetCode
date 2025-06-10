s = "A man, a plan, a canal: Panama"

"""
Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.
"""

def solve_valid_palindrome(s):
    s = s.lower()
    if s == " ":
        return True
    i = 0
    j = len(s) - 1
    while(i <= j):
        if not s[i].isalnum():
            i += 1
        elif not s[j].isalnum():
            j -= 1
        else:
            if s[i] != s[j]:
                return False
            i += 1
            j -= 1
    return True
        