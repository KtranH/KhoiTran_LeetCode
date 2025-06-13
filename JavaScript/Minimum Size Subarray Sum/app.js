const nums = [2,3,1,2,4,3];
const target = 7;

/*
Example 1:

Input: nums = [2,3,1,2,4,3], target = 7
Output: 2
Explanation: The subarray [4,3] has the minimal length under the problem constraint.
Example 2:

Input: nums = [1,2,3,4,5], target = 11
Output: 0
*/

function solve_min_size_subarray_sum(nums, target){
    let n = nums.length;
    let right = 0;
    let left = 0;
    let total = 0;
    let min_length = Number.MAX_SAFE_INTEGER;
    while(right < n){
        total += nums[right];
        while(total >= target){
            let tmp = right - left + 1;
            if(tmp < min_length){
                min_length = tmp;
            }
            total -= nums[left];
            left++;
        }
        right++;
    }
    return min_length === Number.MAX_SAFE_INTEGER ? 0 : min_length;
}

console.log(solve_min_size_subarray_sum(nums, target));
