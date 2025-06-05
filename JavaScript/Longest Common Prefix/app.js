const strs = ["flower","flow","flight"];

/*
Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
*/

function solve_longest_common_prefix(strs) {
    if(strs.length === 0) return "";
    for(let i = 0; i < strs[0].length; i++) {
        let char = strs[0][i];
        for(let j = 0; j < strs.length; j++) {
            if(strs[j][i] !== char || strs[j].length <= i) {
                return strs[0].substring(0, i);
            }
        }
    }
    return strs[0];
}

console.log(solve_longest_common_prefix(strs));
