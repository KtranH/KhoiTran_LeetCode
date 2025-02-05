"""
Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]
"""

nums = [0,0,1]
length_nums = len(nums)

"""
def solve_move_zeros(nums):
    for i in range(length_nums):
        if nums[i] == 0:
           nums.remove(0)
           nums.append(0)
"""

def solve_move_zeros(nums):
    not_zero_index = 0
    for i in range(length_nums):
        if nums[i] != 0:
            nums[not_zero_index] = nums[i]
            not_zero_index += 1
    nums[not_zero_index:] = [0] * (length_nums - not_zero_index)
    return nums

print(solve_move_zeros(nums))