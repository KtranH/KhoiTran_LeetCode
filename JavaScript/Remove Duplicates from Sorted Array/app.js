const nums = [1,1,2];

/*
Example 1:

Input: nums = [1,1,2]
Output: 2, nums = [1,2,_]
Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).
Example 2:

Input: nums = [0,0,1,1,1,2,2,3,3,4]
Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
Explanation: Your function should return k = 5, with the first five elements of nums containing 0, 1, 2, 3, and 4.
Note that the answer is not unique - there are multiple possible answers.
It does not matter what you leave beyond the returned k (hence they are underscores).
*/

function solve_remove_duplicates(nums)
{
    let i = 0;
    for (let j = 1; j < nums.length; j++)
    {
        if (nums[j] != nums[i])
        {
            i++;
            nums[i] = nums[j];
        }
    }
    return i + 1;
}

console.log(solve_remove_duplicates(nums));