const nums = [2,2,1,1,1,2,2];

/*Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2*/

function solve_majority_element(nums)
{
    let count = 0;
    let cadidate = null;
    for (let num of nums)
    {
        if (count == 0)
        {
            cadidate = num;
        }
        count += (num == cadidate ? 1 : -1);
    }
    return cadidate;
}

console.log(solve_majority_element(nums));
