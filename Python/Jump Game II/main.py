nums = [2,3,1,1,4]

"""
Example 1:

Input: nums = [2,3,1,1,4]
Output: 2
Explanation: The minimum number of jumps to reach the last index is 2. Jump 1 step from index 0 to 1, then 3 steps to the last index.
Example 2:

Input: nums = [2,3,0,1,4]
Output: 2
"""

def solve_jump_game(nums):
    n = len(nums)
    currentEnd = 0
    farthest = 0
    jumps = 0
    for i in range(n - 1):
        farthest = max(farthest, i + nums[i])
        if i == currentEnd:
            jumps += 1
            currentEnd = farthest
    return jumps

print(solve_jump_game(nums))
