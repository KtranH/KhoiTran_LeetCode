import math

n = 19

"""
Example 1:

Input: n = 19
Output: true
Explanation:
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1
Example 2:

Input: n = 2
Output: false
"""


def solve_happy_number(n):
    hash_map = {}
    while n != 1 and hash_map.get(n) is None:
        hash_map[n] = True
        new_n = 0
        for i in str(n):
            number = int(i)
            new_n += number ** 2
        n = new_n
    return n == 1

print(solve_happy_number(n))