const nums = [1,1,1,0,0,0,1,1,1,1,0]
const k = 2

function solve_max_consecutive_ones_iii(nums, k) {
    let left = 0
    let zero_count = 0
    let max_length = 0

    for (let right = 0; right < nums.length; right++) {
        if (nums[right] === 0) {
            zero_count++
        }
        if (zero_count > k) {
            if (nums[left] == 0) {
                zero_count--
            }
            left++
        }
        const temp = right - left + 1;
        max_length = max_length < temp ? temp : max_length;
    }
    return max_length
}

console.log(solve_max_consecutive_ones_iii(nums, k)) // Output: 6