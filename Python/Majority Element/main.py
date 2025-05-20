nums = [2,2,1,1,1,2,2]

"""
Example 1:

Input: nums = [3,2,3]
Output: 3
Explanation: The majority element is the element that appears more than ⌊n / 2⌋ times. This element is 3, so we return it.
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
"""

def solve_majority_element(nums):
    count = 0
    cadidate = None
    for num in nums:
        if count == 0:
            cadidate = num
        count += (1 if num == cadidate else -1)
    return cadidate

print(solve_majority_element(nums))