const intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]];
const newInterval = [4,8];

/*
Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
*/

function solve_insert_interval(intervals, newInterval){
    intervals.push(newInterval);
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

console.log(solve_insert_interval(intervals, newInterval));
