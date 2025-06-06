s = "PAYPALISHIRING"
numRows = 3

"""
Example 1:

Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"
Example 2:

Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
"""

def solve_zigzag_conversion(s, numRows):
    if numRows == 1 or numRows >= len(s):
        return s
    result = ""
    step = 2 * (numRows - 1)
    n = len(s)
    for i in range(numRows):
        for j in range(i, n, step):
            result += s[j]
            if i > 0 and i < numRows - 1 and j + step - 2 * i < n:
                result += s[j + step - 2 * i]
    return result

print(solve_zigzag_conversion(s, numRows))