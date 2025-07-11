intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]]
newInterval = [4,8]

"""
Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
"""

def solve_insert_interval(intervals, newInterval):
    intervals.append(newInterval)
    intervals.sort(key=lambda x: x[0])
    result = []
    current = intervals[0]
    for i in range(1, len(intervals)):
        if intervals[i][0] <= current[1]:
            current[1] = max(current[1], intervals[i][1])
        else:
            result.append(current)
            current = intervals[i]
    result.append(current)
    return result

print(solve_insert_interval(intervals, newInterval))
