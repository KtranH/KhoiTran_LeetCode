"""
Example 1:

Input: num = 3
Output: "III"
Example 2:

Input: num = 58
Output: "LVIII"
Example 3:

Input: num = 1994
Output: "MCMXCIV"
"""

def solve_integer_to_roman(num):
    val = [
        1000, 900, 500, 400,
        100,  90,  50,  40,
        10,    9,   5,   4, 1
    ]
    syms = [
        "M", "CM", "D", "CD",
        "C", "XC", "L", "XL",
        "X", "IX", "V", "IV", "I"
    ]
    
    roman = ""
    for i in range(len(val)):
        while num >= val[i]:
            roman += syms[i]
            num -= val[i]
    return roman

print(solve_integer_to_roman(num))
