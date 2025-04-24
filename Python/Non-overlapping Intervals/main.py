intervals = [[1,2],[2,3],[3,4],[1,3]]

"""
Example 1:

Input: intervals = [[1,2],[2,3],[3,4],[1,3]]
Output: 1
Explanation: [1,3] can be removed and the rest of the intervals are non-overlapping.
Example 2:

Input: intervals = [[1,2],[1,2],[1,2]]
Output: 2
Explanation: You need to remove two [1,2] to make the rest of the intervals non-overlapping.
Example 3:

Input: intervals = [[1,2],[2,3]]
Output: 0
Explanation: You don't need to remove any of the intervals since they're already non-overlapping.
"""

def solve_non_overlapping_intervals(intervals):
    intervals.sort(key=lambda x: x[1])
    count_non_overlapping = 0
    last_end = -float('inf')
    for interval in intervals:
        if interval[0] >= last_end:
            count_non_overlapping += 1
            last_end = interval[1]
    return len(intervals) - count_non_overlapping