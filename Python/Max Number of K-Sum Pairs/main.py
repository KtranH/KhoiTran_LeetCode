"""
Example 1:

Input: nums = [1,2,3,4], k = 5
Output: 2
Explanation: Starting with nums = [1,2,3,4]:
- Remove numbers 1 and 4, then nums = [2,3]
- Remove numbers 2 and 3, then nums = []
There are no more pairs that sum up to 5, hence a total of 2 operations.
Example 2:

Input: nums = [3,1,3,4,3], k = 6
Output: 1
Explanation: Starting with nums = [3,1,3,4,3]:
- Remove the first two 3's, then nums = [1,4,3]
There are no more pairs that sum up to 6, hence a total of 1 operation.
"""

nums = [3,1,3,4,3]
k = 5

def solve_max_number_of_ksum_pairs(nums, k):
    count = 0
    nums.sort()
    index_right = len(nums) - 1
    index_left = 0
    while index_left < index_right:
        sum_pairs = nums[index_left] + nums[index_right]
        if sum_pairs == k:
           count += 1
           index_left += 1
           index_right -= 1
        else:
            if sum_pairs > k:
                index_right -= 1
            else:
                index_left += 1
    return count

print(solve_max_number_of_ksum_pairs(nums, k))