const nums = [1,1,1,2,2,3];

/*
Example 1:

Input: nums = [1,1,1,2,2,3]
Output: 5, nums = [1,1,2,2,3,_]
Explanation: Your function should return k = 5, with the first five elements of nums containing 1, 1, 2, 2, and 3 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).
Example 2:

Input: nums = [0,0,1,1,1,1,2,3,3]
Output: 7, nums = [0,0,1,1,2,3,3,_,_]
Explanation: Your function should return k = 7, with the first seven elements of nums containing 0, 0, 1, 1, 2, 3, and 3 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).
*/

function solve_remove_duplicates(nums)
{
    let n = nums.length
    if (n <= 2)
    {
        return n
    }
    let insert_pos = 2
    for (let i = 2; i < n; i++)
    {
        if (nums[i] != nums[insert_pos - 2])
        {
            nums[insert_pos] = nums[i]
            insert_pos++
        }
    }
    return insert_pos
}

console.log(solve_remove_duplicates(nums))
