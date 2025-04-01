nums = [1,2,3,1]

"""
Example 1:

Input: nums = [1,2,3,1]
Output: 2
Explanation: 3 is a peak element and your function should return the index number 2.
Example 2:

Input: nums = [1,2,1,3,5,6,4]
Output: 5
Explanation: Your function can return either index number 1 where the peak element is 2, or index number 5 where the peak element is 6.
"""

def solve_find_peak_element(nums):
    left = 0
    right = len(nums) - 1
    mid = (left + right) // 2
    
    while left < right:
        if nums[mid] > nums[mid + 1]:
            right = mid
        else:
            left = mid + 1
        mid = (left + right) // 2
    
    return left

print(solve_find_peak_element(nums))