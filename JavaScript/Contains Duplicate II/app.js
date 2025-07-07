const nums = [1,2,3,1];
const k = 3;

/*
Example 1:

Input: nums = [1,2,3,1], k = 3
Output: true
Example 2:

Input: nums = [1,0,1,1], k = 1
Output: true
Example 3:

Input: nums = [1,2,3,1,2,3], k = 2
Output: false
*/

function solve_contains_duplicate_ii(nums, k) {
    let hash_map = new Map();
    for (let i = 0; i < nums.length; i++) {
        if (hash_map.has(nums[i])) {
            if (i - hash_map.get(nums[i]) <= k) {
                return true;
            }
        }
        hash_map.set(nums[i], i);
    }
    return false;
}

console.log(solve_contains_duplicate_ii(nums, k));  