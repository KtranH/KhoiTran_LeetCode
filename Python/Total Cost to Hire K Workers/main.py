"""
Example 1:

Input: costs = [17,12,10,2,7,2,11,20,8], k = 3, candidates = 4
Output: 11
Explanation: We hire 3 workers in total. The total cost is initially 0.
- In the first hiring round we choose the worker from [17,12,10,2,7,2,11,20,8]. The lowest cost is 2, and we break the tie by the smallest index, which is 3. The total cost = 0 + 2 = 2.
- In the second hiring round we choose the worker from [17,12,10,7,2,11,20,8]. The lowest cost is 2 (index 4). The total cost = 2 + 2 = 4.
- In the third hiring round we choose the worker from [17,12,10,7,11,20,8]. The lowest cost is 7 (index 3). The total cost = 4 + 7 = 11. Notice that the worker with index 3 was common in the first and last four workers.
The total hiring cost is 11.
Example 2:

Input: costs = [1,2,4,1], k = 3, candidates = 3
Output: 4
Explanation: We hire 3 workers in total. The total cost is initially 0.
- In the first hiring round we choose the worker from [1,2,4,1]. The lowest cost is 1, and we break the tie by the smallest index, which is 0. The total cost = 0 + 1 = 1. Notice that workers with index 1 and 2 are common in the first and last 3 workers.
- In the second hiring round we choose the worker from [2,4,1]. The lowest cost is 1 (index 2). The total cost = 1 + 1 = 2.
- In the third hiring round there are less than three candidates. We choose the worker from the remaining workers [2,4]. The lowest cost is 2 (index 0). The total cost = 2 + 2 = 4.
"""

import heapq
from collections import deque

costs = [17, 12, 10]
k = 3
candidates = 4

def solve_total_cost_to_hire_k_workers(costs, k, candidates):
    left_min_heap = []
    right_min_heap = []
    dq = deque(costs)
    total_cost = 0
    
    for _ in range(min(candidates, len(dq))):
        heapq.heappush(left_min_heap, dq.popleft())
    for _ in range(min(candidates, len(dq))):
        heapq.heappush(right_min_heap, dq.pop())
    
    for _ in range(k):
        if not right_min_heap or (left_min_heap and left_min_heap[0] <= right_min_heap[0]):
            total_cost += heapq.heappop(left_min_heap)
            if dq:
                heapq.heappush(left_min_heap, dq.popleft())
        else:
            total_cost += heapq.heappop(right_min_heap)
            if dq:
                heapq.heappush(right_min_heap, dq.pop())
    return total_cost
    
print(solve_total_cost_to_hire_k_workers(costs, k, candidates))