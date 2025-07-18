const tokens = ["2", "1", "+", "3", "*"];

/*
Example 1:

Input: tokens = ["2","1","+","3","*"]
Output: 9
Explanation: ((2 + 1) * 3) = 9
Example 2:

Input: tokens = ["4","13","5","/","+"]
Output: 6
Explanation: (4 + (13 / 5)) = 6
Example 3:

Input: tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]
Output: 22
*/

function solve_ReversePolishNotation(tokens) {
    let stack = [];
    for (let i = 0; i < tokens.length; i++) {
        if (tokens[i] === "+") {
            stack.push(stack.pop() + stack.pop());
        } else if (tokens[i] === "-") {
            let b = stack.pop();
            let a = stack.pop();
            stack.push(a - b);
        } else if (tokens[i] === "*") {
            stack.push(stack.pop() * stack.pop());
        } else if (tokens[i] === "/") {
            let b = stack.pop();
            let a = stack.pop();
            stack.push(Math.trunc(a / b));
        } else {
            stack.push(Number(tokens[i]));
        }
    }
    return stack.pop();
}

console.log(solve_ReversePolishNotation(tokens));
