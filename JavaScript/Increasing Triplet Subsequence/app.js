/*Example 1:

Input: nums = [1,2,3,4,5]
Output: true
Explanation: Any triplet where i < j < k is valid.
Example 2:

Input: nums = [5,4,3,2,1]
Output: false
Explanation: No triplet exists.
Example 3:

Input: nums = [2,1,5,0,4,6]
Output: true
Explanation: The triplet (3, 4, 5) is valid because nums[3] == 0 < nums[4] == 4 < nums[5] == 6.*/

const nums = [2,1,5,0,4,6];

function solve_increase_triplet(nums){
    let first = Math.max(...nums) + 1;
    let second = Math.max(...nums) + 1;
    for(let i = 0; i < nums.length; i++){
        if(nums[i] <= first){
            first = nums[i];
        }else if(nums[i] <= second){
            second = nums[i];
        }else{
            return true;
        }
    }
    return false;
}

console.log(solve_increase_triplet(nums));