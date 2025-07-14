const s = "()[]{}";

/*
Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
*/

function solve_valid_parentheses(s) {
    let stack = [];
    for (let i = 0; i < s.length; i++) {
        if (s[i] === '(' || s[i] === '[' || s[i] === '{') {
            stack.push(s[i]);
        } else {
            if (stack.length === 0) return false;
            let top = stack.pop();
            if (s[i] === ')' && top !== '(') return false;
            if (s[i] === ']' && top !== '[') return false;
            if (s[i] === '}' && top !== '{') return false;
        }
    }
    return stack.length === 0;    
}

console.log(solve_valid_parentheses(s));
