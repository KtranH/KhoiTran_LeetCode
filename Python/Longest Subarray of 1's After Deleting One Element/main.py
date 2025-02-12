"""
Example 1:

Input: nums = [1,1,0,1]
Output: 3
Explanation: After deleting the number in position 2, [1,1,1] contains 3 numbers with value of 1's.
Example 2:

Input: nums = [0,1,1,1,0,1,1,0,1]
Output: 5
Explanation: After deleting the number in position 4, [0,1,1,1,1,1,0,1] longest subarray with value of 1's is [1,1,1,1,1].
Example 3:

Input: nums = [1,1,1]
Output: 2
Explanation: You must delete one element.
"""

nums = [1,1,1]

def solve_longest_subarray_of_1s_after_deleting_one_element(nums):
    left_index = 0
    zero_count = 0
    max_length = 0

    for right_index in range(len(nums)):
        if nums[right_index] == 0:
            zero_count += 1
        while zero_count > 1:
            if nums[left_index] == 0: zero_count -= 1
            left_index += 1
        length_right = right_index - left_index
        if max_length < length_right: max_length = length_right

    return max_length

print(solve_longest_subarray_of_1s_after_deleting_one_element(nums))