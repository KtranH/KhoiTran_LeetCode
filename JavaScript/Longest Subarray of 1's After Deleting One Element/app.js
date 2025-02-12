const nums = [1,1,0,1]

function solve_longest_subarray_of_1s_after_deleting_one_element(nums)
{
    let left = 0
    let zero_count = 0
    let max_length = 0

    for (let right = 0; right < nums.length; right++) {
        if (nums[right] == 0) {
            zero_count++
        }
        while (zero_count > 1) {
            if (nums[left] == 0) {
                zero_count--
            }
            left++
        }
        max_length = max_length < (right - left) ? (right - left) : max_length
    }
    return max_length
}

console.log(solve_longest_subarray_of_1s_after_deleting_one_element(nums)) // Output: 3