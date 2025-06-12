const nums = [-1,0,1,2,-1,-4];

/*
Example 1:

Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Explanation: 
nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
The distinct triplets are [-1,0,1] and [-1,-1,2].
Notice that the order of the output and the order of the triplets does not matter.
Example 2:

Input: nums = [0,1,1]
Output: []
Explanation: The only possible triplet does not sum up to 0.
Example 3:

Input: nums = [0,0,0]
Output: [[0,0,0]]
Explanation: The only possible triplet sums up to 0.
*/

function solve_3sum(nums){
    let n = nums.length;
    let result = [];
    nums.sort((a, b) => a - b);
    for(let i = 0; i < n; i++){
        if(i > 0 && nums[i] == nums[i - 1]) continue;
        let left = i + 1;
        let right = n - 1;
        while(left < right){
            let total = nums[i] + nums[left] + nums[right];
            if(total == 0){
                result.push([nums[i], nums[left], nums[right]]);
                while(left < right && nums[left] == nums[left + 1]) left++;
                while(left < right && nums[right] == nums[right - 1]) right--;
                left++;
                right--;
            }else if(total < 0){
                left++;
            }else{
                right--;
            }
        }
    }
    return result;
}

console.log(solve_3sum(nums));
