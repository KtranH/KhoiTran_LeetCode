"""
Example 1:

Input: nums = [3,2,1,5,6,4], k = 2
Output: 5
Example 2:

Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
Output: 4
"""

import heapq
nums = [3,2,1,5,6,4]
k = 2

def solve_kth_largest_element_in_an_array(nums, k):
    min_head = []
    for i in nums:
        heapq.heappush(min_head, i)
        if len(min_head) > k:
            heapq.heappop(min_head)
    return min_head[0]

print(solve_kth_largest_element_in_an_array(nums, k))