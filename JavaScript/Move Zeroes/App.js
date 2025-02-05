/*Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]*/

const nums = [0,1,0,3,12];

function solve_move_zeroes(nums) {
    let not_zero_index = 0;
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] !== 0) {
            nums[not_zero_index] = nums[i];
            not_zero_index++;
        }
    }
    for (let i = not_zero_index; i < nums.length; i++) {
        nums[i] = 0;
    }
}

solve_move_zeroes(nums);