/*Example 1:

Input: nums = [1,2,3,4], k = 5
Output: 2
Explanation: Starting with nums = [1,2,3,4]:
- Remove numbers 1 and 4, then nums = [2,3]
- Remove numbers 2 and 3, then nums = []
There are no more pairs that sum up to 5, hence a total of 2 operations.
Example 2:

Input: nums = [3,1,3,4,3], k = 6
Output: 1
Explanation: Starting with nums = [3,1,3,4,3]:
- Remove the first two 3's, then nums = [1,4,3]
There are no more pairs that sum up to 6, hence a total of 1 operation.*/

const nums = [63,10,28,31,90,53,75,77,72,47,45,6,49,13,77,61,68,43,33,1,14,62,55,55,38,54,8,79,89,14,50,68,85,12,42,57,4,67,75,6,71,8,61,26,11,20,22,3,70,52,82,70,67,18,66,79,84,51,78,23,19,84,46,61,63,73,80,61,15,12,58,3,21,66,42,55,7,58,85,60,23,69,41,61,35,64,58,84,61,77,45,14,1,38,4,8,42,16,79,60,80,39,67,10,24,15,6,37,68,76,30,53,63,87,11,71,86,82,77,76,37,21,85,7,75,83,80,8,19,25,11,10,41,66,70,14,23,74,33,76,35,89,68,85,83,57,6,72,34,21,57,72,79,29,65,3,67,8,24,24,18,26,27,68,78,64,57,55,68,28,9,11,38,45,61,37,81,89,38,43,45,26,84,62,22,37,51,15,30,67,75,24,66,40,81,74,48,43,78,14,33,19,73,5,1,2,53,29,49,73,23,5];
const k = 59

function sort_nums(nums)
{
    if (nums.length <= 1)
    {
        return nums;
    }
    let mid = Math.floor(nums.length / 2);
    let left = sort_nums(nums.slice(0, mid));
    let right = sort_nums(nums.slice(mid));
    return merge_sort(left, right);
}
function merge_sort(left,right)
{
    let result = [];
    let i = 0;
    let j = 0;
    while(i < left.length && j < right.length)
    {
        if(left[i] <= right[j])
        {
            result.push(left[i]);
            i++;
        }
        else
        {
            result.push(right[j]);
            j++;
        }
    }
    return result.concat(left.slice(i)).concat(right.slice(j));
}
function solve_max_number_of_k_sum_pairs(nums,k)
{
    //nums = sort_nums(nums);
    nums.sort((a,b) => a - b);
    let count = 0;
    let left = 0;
    let right = nums.length - 1;
    while(left < right)
    {
        let sum = nums[left] + nums[right];
        if(sum == k)
        {
            count++;
            left++;
            right--;
        }
        else
        {
            if(sum < k)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
    }
    return count;
}

console.log(solve_max_number_of_k_sum_pairs(nums, k), nums); 