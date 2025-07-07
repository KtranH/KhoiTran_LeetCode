nums = [1,2,3,1]
k = 3

"""
Example 1:

Input: nums = [1,2,3,1], k = 3
Output: true
Example 2:

Input: nums = [1,0,1,1], k = 1
Output: true
Example 3:

Input: nums = [1,2,3,1,2,3], k = 2
Output: false
"""

def solve_contains_duplicate_ii(nums, k):
    hash_map = {}
    for i in range(len(nums)):
        if nums[i] in hash_map:
            if abs(hash_map[nums[i]] - i) <= k:
                return True
        hash_map[nums[i]] = i
    return False

print(solve_contains_duplicate_ii(nums, k))
