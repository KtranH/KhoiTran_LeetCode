const nums = [100,4,200,1,3,2];

/*
Example 1:

Input: nums = [100,4,200,1,3,2]
Output: 4
Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
Example 2:

Input: nums = [0,3,7,2,5,8,4,6,0,1]
Output: 9
Example 3:

Input: nums = [1,0,1,2]
Output: 3
*/

function solve_longest_consecutive_sequence(nums) {
    const hash_set = new Set(nums);
    let longest_streak = 0;
    for (let num of hash_set) {
        if (!hash_set.has(num - 1)) {
            let current_num = num;
            let current_streak = 1;
            while (hash_set.has(current_num + 1)) {
                current_num += 1;
                current_streak += 1;
            }
            longest_streak = Math.max(longest_streak, current_streak);
        }
    }
    return longest_streak;
}

console.log(solve_longest_consecutive_sequence(nums));
