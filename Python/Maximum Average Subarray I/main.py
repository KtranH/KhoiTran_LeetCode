"""
Example 1:

Input: nums = [1,12,-5,-6,50,3], k = 4
Output: 12.75000
Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
Example 2:

Input: nums = [5], k = 1
Output: 5.00000
"""

nums = [1,12,-5,-6,50,3]
k = 4


def solve_maximum_average_subarray_i(nums, k):
    if k > len(nums):
        return 0
    
    window_sum = sum(nums[:k])
    max_sum = window_sum

    for i in range(k, len(nums)):
        window_sum += nums[i] - nums[i - k]
        max_sum = max(max_sum, window_sum)

    return round(max_sum / k, 5)

print(solve_maximum_average_subarray_i(nums, k))    