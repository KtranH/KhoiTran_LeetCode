/*Example 1:

Input: temperatures = [73,74,75,71,69,72,76,73]
Output: [1,1,4,2,1,1,0,0]
Example 2:

Input: temperatures = [30,40,50,60]
Output: [1,1,1,0]
Example 3:

Input: temperatures = [30,60,90]
Output: [1,1,0]*/

const temperatures = [73,74,75,71,69,72,76,73];

function solve_daily_temperatures(temperatures) {
    let n = temperatures.length;
    let result = new Array(n).fill(0);
    let stack = [];
    for (let i = 0; i < n; i++) {
        while (stack.length > 0 && temperatures[i] > temperatures[stack[stack.length - 1]]) {
            let prev = stack.pop();
            result[prev] = i - prev;
        }
        stack.push(i);
    }
    return result;
}