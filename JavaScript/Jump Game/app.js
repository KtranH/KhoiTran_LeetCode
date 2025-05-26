const nums = [2,3,1,1,4];

/*
Example 1:

Input: nums = [2,3,1,1,4]
Output: true
Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
Example 2:

Input: nums = [3,2,1,0,4]
Output: false
Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.
*/

function solve_jump_game(nums) {
    const n = nums.length;
    let max_reach = 0;
    for (let i = 0; i < n; i++) {
        if (i > max_reach) {
            return false;
        }
        max_reach = Math.max(max_reach, i + nums[i]);
    }
    return true;
}

console.log(solve_jump_game(nums));
