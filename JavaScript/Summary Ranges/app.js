const nums = [0,2,3,4,6,8,9];

/*
Example 1:

Input: nums = [0,2,3,4,6,8,9]
Output: ["0","2->4","6","8->9"]
Explanation: The ranges are:
[0,0] --> "0"
[2,4] --> "2->4"
[6,6] --> "6"
[8,9] --> "8->9"
Example 2:

Input: nums = [0,1,2,4,5,7]
Output: ["0->2","4->5","7"]
Explanation: The ranges are:
[0,2] --> "0->2"
[4,5] --> "4->5"
[7,7] --> "7"
*/

function solve_summary_ranges(nums){
    const n = nums.length;
    if(n === 0) return [];
    let result = [];
    let start = nums[0];
    for(let i = 1; i < n; i++){
        if(nums[i] !== nums[i - 1] + 1){
            let end = nums[i - 1];
            if(start === end){
                result.push(start.toString());
            }else{
                result.push(start.toString() + "->" + end.toString());
            }
            start = nums[i];
        }
    }
    if(start === nums[n - 1]){
        result.push(start.toString());
    }else{
        result.push(start.toString() + "->" + nums[n - 1].toString());
    }
    return result;
}
console.log(solve_summary_ranges(nums));
