const pattern = "abba";
const s = "dog cat cat dog";

/*
Example 1:

Input: pattern = "abba", s = "dog cat cat dog"
Output: true
Example 2:

Input: pattern = "abba", s = "dog cat cat fish"
Output: false
Example 3:

Input: pattern = "aaaa", s = "dog cat cat dog"
Output: false
Example 4:

Input: pattern = "abba", s = "dog dog dog dog"
Output: false
*/

function solve_word_pattern(pattern, s) {
    s = s.split(" ");
    if (pattern.length !== s.length) {
        return false;
    }
    let pattern_map = {};
    for (let i = 0; i < pattern.length; i++) {
        if (pattern_map[pattern[i]] === undefined) {
            if (Object.values(pattern_map).includes(s[i])) {
                return false;
            }
            pattern_map[pattern[i]] = s[i];
        } else {
            if (pattern_map[pattern[i]] !== s[i]) {
                return false;
            }
        }
    }
    return true;
}

console.log(solve_word_pattern(pattern, s));