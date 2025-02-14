"""
Example 1:

Input: nums = [1,7,3,6,5,6]
Output: 3
Explanation:
The pivot index is 3.
Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11
Right sum = nums[4] + nums[5] = 5 + 6 = 11
Example 2:

Input: nums = [1,2,3]
Output: -1
Explanation:
There is no index that satisfies the conditions in the problem statement.
Example 3:

Input: nums = [2,1,-1]
Output: 0
Explanation:
The pivot index is 0.
Left sum = 0 (no elements to the left of index 0)
Right sum = nums[1] + nums[2] = 1 + -1 = 0
"""

nums = [1,7,3,6,5,6]

def solve_find_pivot_index(nums):
    total_sum = 0
    length_nums = len(nums)

    for i in range(length_nums):
        total_sum += nums[i]

    left_sum = 0
    for i in range(length_nums):
        if left_sum == total_sum - left_sum - nums[i]:
            return i
        left_sum += nums[i]
    return -1

print(solve_find_pivot_index(nums))