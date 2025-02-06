/*Example 1:

Input: s = "abc", t = "ahbgdc"
Output: true
Example 2:

Input: s = "axc", t = "ahbgdc"
Output: false*/

const s = "abc";
const t = "ahbgdc";

function solve_is_subsequence(s, t)
{
    if (s.length === 0) return true;
    let check_index = 0;
    for (let i = 0; i < t.length; i++) {
        if (s[check_index] === t[i]) {
            check_index++;
            if (check_index === s.length) return true;
        }
    }
    return false;
}

console.log(solve_is_subsequence(s, t)); // Output: true