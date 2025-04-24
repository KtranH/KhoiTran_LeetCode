intervals = [[1,2],[2,3],[3,4],[1,3]] 

/*Example 1:

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
Explanation: You don't need to remove any of the intervals since they're already non-overlapping.*/

function solve_non_overlapping_intervals(intervals) {
    intervals.sort((a, b) => a[1] - b[1]);
    let count_non_overlapping = 0;
    let last_end = -Infinity;
    for (let interval of intervals) {
        if (interval[0] >= last_end) {
            count_non_overlapping++;
            last_end = interval[1];
        }
    }
    return intervals.length - count_non_overlapping;
}

console.log(solve_non_overlapping_intervals(intervals));