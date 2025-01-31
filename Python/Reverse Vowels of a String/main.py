"""
Example 1:

Input: s = "IceCreAm"

Output: "AceCreIm"

Explanation:

The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

Example 2:

Input: s = "leetcode"

Output: "leotcede"
"""

vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U']
s = "leetcode"

def slove_reverse_vowels(s):
    length_string = len(s)
    count = length_string
    s = list(s)
    for i in range(length_string):
        if s[i] in vowels:
           for j in reversed(range(i, length_string - (length_string - count))):
               if s[j] in vowels:
                   s[i], s[j] = s[j], s[i]
                   count = j
                   break
    return "".join(s)

print(slove_reverse_vowels(s))
