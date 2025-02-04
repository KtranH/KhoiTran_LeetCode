"""
Example 1:

Input: str1 = "ABCABC", str2 = "ABC"
Output: "ABC"
Example 2:

Input: str1 = "ABABAB", str2 = "ABAB"
Output: "AB"
Example 3:

Input: str1 = "LEET", str2 = "CODE"
Output: ""
"""

import math

word1 = "ABABAB"
word2 = "ABAB"

def check_in_string(word1, word2):
    if len(word1) > len(word2):
        for i in range(len(word1)):
            if word1[i] != word2[i % len(word2)]:
                return False
    elif len(word1) < len(word2):
        for i in range(len(word2)):
            if word2[i] != word1[i % len(word1)]:
                return False
    else:
        if word1 not in word2:
            return False
    return True
def solve_Greatest_Common_Divisor_of_Strings(word1, word2):
    if not check_in_string(word1, word2):
        return ""
    else:
        if(len(word1) > len(word2)):
            if word2 not in word1:
                return ""
            test = word1[:math.gcd(len(word1), len(word2))]
            if not check_in_string(word2, test):
                return ""
            return test
        else:
            if word1 not in word2:
                return ""
            test = word2[:math.gcd(len(word1), len(word2))]
            if not check_in_string(word1, test):
                return ""
            return test

print(solve_Greatest_Common_Divisor_of_Strings(word1, word2))