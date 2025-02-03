"""
Example 1:

Input: nums = [1,2,3,4,5]
Output: true
Explanation: Any triplet where i < j < k is valid.
Example 2:

Input: nums = [5,4,3,2,1]
Output: false
Explanation: No triplet exists.
Example 3:

Input: nums = [2,1,5,0,4,6]
Output: true
Explanation: The triplet (3, 4, 5) is valid because nums[3] == 0 < nums[4] == 4 < nums[5] == 6.
"""

nums = [1,5,0,4,1,3]
length = len(nums)
count = 3

def find_pos(nums, min_num):
    for i in range(length):
        if nums[i] == min_num:
            return i
        
"""
def slove_increasing_triplet_subsequence(nums):
    global count

    pos_temp = -1

    min_temp = min(nums) - 1
    max_num = max(nums) + 1


    for i in range(length):
        min_num = min(nums)
        pos_min = find_pos(nums, min_num)
        if min_num > min_temp and pos_min > pos_temp and pos_min + count <= length:
            print(min_num, min_temp, pos_min, pos_temp, count, length)
            min_temp = min_num
            pos_temp = pos_min
            count -= 1
            nums[pos_min] = max_num
            if count == 0:
               break
        else:
            nums[pos_min] = max_num
            pos_temp = pos_min
    return count == 0   
"""

def solve_increasing_triplet_subsequence(nums):
    if not nums or len(nums) < 3:
        return False
    
    first = max(nums) + 1
    second = max(nums) + 1
    
    for num in nums:
        if num <= first:
            first = num
        elif num <= second:
            second = num
        else:
            return True
    
    return False

print(solve_increasing_triplet_subsequence(nums))