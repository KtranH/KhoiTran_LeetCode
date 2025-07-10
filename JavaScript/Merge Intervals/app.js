const nums = [[1,3],[2,6],[8,10],[15,18]];


/*
Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
*/
function solve_merge_intervals(intervals){
    intervals.sort((a, b) => a[0] - b[0]);
    let result = [];
    let current = intervals[0];
    for(let i = 1; i < intervals.length; i++){
        if(intervals[i][0] <= current[1]){
            current[1] = Math.max(current[1], intervals[i][1]);
        }else{
            result.push(current);
            current = intervals[i];
        }
    }
    result.push(current);
    return result;
}

console.log(solve_merge_intervals(nums));
