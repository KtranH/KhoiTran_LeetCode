numbers = [2,7,11,15]
target = 9

"""
Example 1:

Input: numbers = [2,7,11,15], target = 9
Output: [0,1]
Explanation: The sum of 2 and 7 is 9. Therefore index 0 and 1 are returned.
Example 2:

Input: numbers = [2,3,4], target = 6
Output: [0,2]
Explanation: The sum of 2 and 4 is 6. Therefore index 0 and 2 are returned.
Example 3:

Input: numbers = [-1,0], target = -1
Output: [0,1]
Explanation: The sum of -1 and 0 is -1. Therefore index 0 and 1 are returned.
"""

def solve_two_sum(numbers, target):
    left = 0
    right = len(numbers) - 1
    while left < right:
        if numbers[left] + numbers[right] == target:
            return [left + 1, right + 1]
        elif numbers[left] + numbers[right] < target:
            left += 1
        else:
            right -= 1
    return []

print(solve_two_sum(numbers, target))