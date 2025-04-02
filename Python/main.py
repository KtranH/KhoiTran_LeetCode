piles = [3,6,7,11]
h = 8

"""
Example 1:

Input: piles = [3,6,7,11], h = 8
Output: 4
Example 2:

Input: piles = [30,11,23,4,20], h = 5
Output: 30
Example 3:

Input: piles = [30,11,23,4,20], h = 6
Output: 23
"""

def solve_koko_eating_piles(piles, h):
    left,right = 1, max(piles)
    while left < right:
        mid = (left + right) // 2
        total_hours = 0
        for pile in piles:
            total_hours += math.ceil(pile / mid)
        if total_hours > h:
            left = mid + 1
        else:
            right = mid
    return left

print(solve_koko_eating_piles(piles, h))
