nums = [100,4,200,1,3,2]

"""
Example 1:

Input: nums = [100,4,200,1,3,2]
Output: 4
Explanation: 1 is the starting index. The sequence is [1,2,3,4].
Example 2:

Input: nums = [0,3,7,2,5,8,4,6,0,1]
Output: 9
"""

def solve_longest_consecutive_sequence(nums):
    hash_set = set(nums)
    longest_streak = 0
    for num in hash_set:
        if num - 1 not in hash_set:
            current_num = num
            current_streak = 1
            while current_num + 1 in hash_set:
                current_num += 1
                current_streak += 1
            longest_streak = max(longest_streak, current_streak)
    return longest_streak

print(solve_longest_consecutive_sequence(nums))
