nums = [2,3,1,2,4,3]
target = 7

"""
Example 1:

Input: nums = [2,3,1,2,4,3], target = 7
Output: 2
Explanation: The subarray [4,3] has the minimal length under the problem constraint.
Example 2:

Input: nums = [1,2,3,4,5], target = 11
Output: 0
"""

def solve_min_size_subarray_sum(nums, target):
    n = len(nums)
    right = 0
    left = 0
    total = 0
    min_length = float('inf')
    while right < n:
        total += nums[right]
        while total >= target:
            tmp = right - left + 1
            if tmp < min_length:
                min_length = tmp
            total -= nums[left]
            left += 1
        right += 1
    return min_length if min_length != float('inf') else 0

print(solve_min_size_subarray_sum(nums, target))
