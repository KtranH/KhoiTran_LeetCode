ransomNote = "a", magazine = "b"

"""
Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
"""

def solve_ransom_note(ransomNote, magazine):
    magazine_map = {}
    for i in magazine:
        if i in magazine_map:
            magazine_map[i] += 1
        else:
            magazine_map[i] = 1
    for i in ransomNote:
        if i in magazine_map and magazine_map[i] > 0:
            magazine_map[i] -= 1
        else:
            return False
    return True

print(solve_ransom_note(ransomNote, magazine))
