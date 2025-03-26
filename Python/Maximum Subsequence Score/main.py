import heapq
from typing import List
import numpy as np

"""
Example 1:

Input: nums1 = [1,3,3,2], nums2 = [2,1,3,4], k = 3
Output: 12
Explanation: 
The four possible subsequence scores are:
- We choose the indices 0, 1, and 2 with score = (1+3+3) * min(2,1,3) = 7.
- We choose the indices 0, 1, and 3 with score = (1+3+2) * min(2,1,4) = 6. 
- We choose the indices 0, 2, and 3 with score = (1+3+2) * min(2,3,4) = 12. 
- We choose the indices 1, 2, and 3 with score = (3+3+2) * min(1,3,4) = 8.
Therefore, we return the max score, which is 12.
Example 2:

Input: nums1 = [4,2,3,1,1], nums2 = [7,5,10,9,6], k = 1
Output: 30
Explanation: 
Choosing index 2 is optimal: nums1[2] * nums2[2] = 3 * 10 = 30 is the maximum possible score.
"""

nums1 = [1,3,3,2]
nums2 = [2,1,3,4]
k = 3

def solve_maximum_subsequence_score(nums1, nums2, k):
    sorted_indices = np.argsort(-np.array(nums2)) 

    min_heap = [] 
    sum_selected = 0
    max_result = 0

    for i in sorted_indices:
        if len(min_heap) < k:
            heapq.heappush(min_heap, nums1[i])
            print(min_heap)
            sum_selected += nums1[i]
        else:
            if nums1[i] > min_heap[0]: 
                sum_selected += nums1[i] - heapq.heapreplace(min_heap, nums1[i])

        if len(min_heap) == k:
            max_result = max(max_result, sum_selected * nums2[i])

    return max_result
    

print(solve_maximum_subsequence_score(nums1, nums2, k))
