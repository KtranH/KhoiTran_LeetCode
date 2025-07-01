const s = "anagram";
const t = "nagaram";

/*
Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false
*/

function solve_valid_anagram(s, t) {
    let s_map = {}
    for (let i = 0; i < s.length; i++) {
        if (s_map[s[i]]) {
            s_map[s[i]]++;
        } else {
            s_map[s[i]] = 1;
        }
    }
    let t_map = {}
    for (let i = 0; i < t.length; i++) {
        if (t_map[t[i]]) {
            t_map[t[i]]++;
        } else {
            t_map[t[i]] = 1;
        }
    }
    if (Object.keys(s_map).length != Object.keys(t_map).length) {
        return false;
    }
    for (let key in s_map) {
        if (s_map[key] != t_map[key] || !t_map[key]) {
            return false;
        }
    }
    return true;
}

console.log(solve_valid_anagram(s, t));
