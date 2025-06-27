const s = "egg";
const t = "add";

/*
Example 1:

Input: s = "egg", t = "add"
Output: true
Example 2:

Input: s = "foo", t = "bar"
Output: false
Example 3:

Input: s = "paper", t = "title"
Output: true
*/

function solve_isomorphic(s, t) {
    let map_s_t = {};
    let map_t_s = {};
    
    for (let i = 0; i < s.length; i++) {
        if (s[i] in map_s_t) {
            if (map_s_t[s[i]] != t[i]) {
                return false;
            }
        } else {
            map_s_t[s[i]] = t[i];
        }
        if (t[i] in map_t_s) {
            if (map_t_s[t[i]] != s[i]) {
                return false;
            }
        } else {
            map_t_s[t[i]] = s[i];
        }
    }
    return true;
}

console.log(solve_isomorphic(s, t));