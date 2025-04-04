/*Example 1:

Input: k = 3, n = 7
Output: [[1,2,4]]
Explanation:
1 + 2 + 4 = 7
There are no other valid combinations.
Example 2:

Input: k = 3, n = 9
Output: [[1,2,6],[1,3,5],[2,3,4]]
Explanation:
1 + 2 + 6 = 9
1 + 3 + 5 = 9
2 + 3 + 4 = 9
There are no other valid combinations.
Example 3:

Input: k = 4, n = 1
Output: []
Explanation: There are no valid combinations.
Using 4 different numbers in the range [1,9], the smallest sum we can get is 1+2+3+4 = 10 and since 10 > 1, there are no valid combination.*/


const k = 3;
const n = 7;


function backtracking(start, target, path, k, result) {
    if (path.length === k && target === 0) {
        result.push(path.slice());
        return;
    }
    if (path.length >= k || target < 0) {
        return;
    }
    for (let i = start; i <= 9; i++) {
        path.push(i);
        backtracking(i + 1, target - i, path, k, result);
        path.pop();
    }
}
function solve_combination_sum_iii() {
    if (k === 0 || n === 0) {
        return [];
    }
    const result = [];
    const path = [];
    backtracking(1, n, path, k, result);
    return result;
}

let result = solve_combination_sum_iii();
console.log(result);