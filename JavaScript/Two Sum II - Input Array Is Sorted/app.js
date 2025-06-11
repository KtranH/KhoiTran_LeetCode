const numbers = [2,7,11,15];
const target = 9;

/*
Example 1:

Input: numbers = [2,7,11,15], target = 9
Output: [0,1]
Explanation: The sum of 2 and 7 is 9. Therefore index 0 and 1 are returned.
Example 2:

Input: numbers = [2,3,4], target = 6
Output: [0,2]
Explanation: The sum of 2 and 4 is 6. Therefore index 0 and 2 are returned.
Example 3:

Input: numbers = [-1,0], target = -1
Output: [0,1]
Explanation: The sum of -1 and 0 is -1. Therefore index 0 and 1 are returned.
*/

function solve_two_sum(numbers, target) {
    let left = 0;
    let right = numbers.length - 1;
    while (left < right) {
        if (numbers[left] + numbers[right] == target) {
            return [left + 1, right + 1];
        } else if (numbers[left] + numbers[right] < target) {
            left++;
        } else {
            right--;
        }
    }
    return [];
}

console.log(solve_two_sum(numbers, target));