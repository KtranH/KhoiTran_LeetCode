/*Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]*/

const nums = [1, 2, 3, 4];

function solve_product_of_array_except_self(nums) {
    let result = [];
    let prefix = 1;
    for (let i = 0; i < nums.length; i++) {
        result[i] = prefix;
        prefix *= nums[i];
    }
    let postfix = 1;
    for (let i = nums.length - 1; i >= 0; i--) {
        result[i] *= postfix;
        postfix *= nums[i];
    }
    return result;
}

console.log(solve_product_of_array_except_self(nums));