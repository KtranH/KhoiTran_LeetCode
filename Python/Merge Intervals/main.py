intervals = [[1,3],[2,6],[8,10],[15,18]]

"""
Example 1:

Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].
Example 2:

Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.
"""

def solve_merge_intervals(intervals):
    intervals.sort(key=lambda x: x[0])
    result = []
    for i in range(1,len(intervals)):
        if intervals[i][0] <= intervals[i-1][1]:
            intervals[i][1] = max(intervals[i][1], intervals[i-1][1])
            intervals[i][0] = min(intervals[i][0], intervals[i-1][0])
        else:
            result.append(intervals[i-1])
    result.append(intervals[-1])
    return result
        

print(solve_merge_intervals(intervals))
