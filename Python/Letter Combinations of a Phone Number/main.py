"""
Example 1:

Input: digits = "23"
Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
Example 2:

Input: digits = ""
Output: []
Example 3:

Input: digits = "2"
Output: ["a","b","c"]
"""

digits = "23"

def backtracking(index, path, digits, result, lenDigits, digits_to_char):
    if index == lenDigits:
        result.append(path)
        return
    
    current_digit = digits[index]
    for char in digits_to_char[current_digit]:
        backtracking(index + 1, path + char, digits, result, lenDigits, digits_to_char)

def solve_letter_combinations(digits):
    if not digits:
        return []
    result = []
    lenDigits = len(digits)
    digits_to_char = {
        "2": "abc",
        "3": "def",
        "4": "ghi",
        "5": "jkl",
        "6": "mno",
        "7": "pqrs",
        "8": "tuv",
        "9": "wxyz"
    }
    backtracking(0, "", digits, result, lenDigits, digits_to_char)
    return result
    
