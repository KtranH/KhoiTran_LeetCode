const path = "/home//foo/";

/*
Example 1:

Input: path = "/home//foo/"
Output: "/home/foo"
Explanation: In the canonical path, multiple slashes are replaced by a single one.
Example 2:

Input: path = "/a/./b/../../c/"
Output: "/c"
*/

function solve_simplify_path(path) {
    let stack = [];
    let tokens = path.split('/');
    for (let token of tokens) {
        if (token === '' || token === '.') {
            continue;
        } else if (token === '..') {
            if (stack.length > 0) {
                stack.pop();
            }
        } else {
            stack.push(token);
        }
    }
    return '/' + stack.join('/');
}

console.log(solve_simplify_path(path));
