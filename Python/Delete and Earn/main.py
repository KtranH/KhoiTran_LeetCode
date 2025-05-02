nums = [3,4,5]

"""
Example 1:

Input: nums = [3,4,2]
Output: 6
Explanation: You can either take the $3, the $4, or take both coins. The maximum amount of money you can rob is $6.
Example 2:

Input: nums = [2,2,3,3,3,4]
Output: 9
Explanation: You can either take the $2, the $3, or the $4. The maximum amount of money you can rob from these coins is $9.
"""
from collections import Counter

def solve_delete_and_earn(nums):
    if not nums:
        return 0
    counter = Counter(nums)
    unique_nums = sorted(counter)
    prev = None
    avoid = using = 0
    for num in unique_nums:
        curr_points = num * counter[num]
        
        if prev is not None and num == prev + 1:
            new_avoid = max(avoid, using)
            new_using = avoid + curr_points
        else:
            new_avoid = max(avoid, using)
            new_using = new_avoid + curr_points

        avoid, using = new_avoid, new_using
        prev = num

    return max(avoid, using)

print(solve_delete_and_earn(nums))
