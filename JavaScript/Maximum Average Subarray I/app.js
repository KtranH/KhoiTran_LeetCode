const nums = [1,12,-5,-6,50,3];
const k = 4

function solve_maximum_average_subarray(nums, k) {
    let sliding_window = nums.slice(0, k).reduce((a, b) => a + b, 0);
    /*for (let i = 0; i < k; i++) 
    {
        sliding_window += nums[i];
    }*/
    let max_sum = sliding_window;
    for (let i = k; i < nums.length; i++)
    {
        sliding_window += nums[i] - nums[i - k];
        max_sum = Math.max(max_sum, sliding_window);
    }
    return max_sum / k;
}

console.log(solve_maximum_average_subarray(nums, k)); 