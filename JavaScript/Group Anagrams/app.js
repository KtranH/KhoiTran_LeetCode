const strs = ["eat","tea","tan","ate","nat","bat"];

/*
Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
Example 2:

Input: strs = [""]
Output: [[""]]
*/

function solve_group_anagrams(strs) {
    let strs_map = new Map();
    for (let i = 0; i < strs.length; i++) {
        let c_sort = strs[i].split('').sort().join('');
        if (strs_map.has(c_sort)) {
            strs_map.get(c_sort).push(strs[i]);
        } else {
            strs_map.set(c_sort, [strs[i]]);
        }
    }
    return Array.from(strs_map.values());
}

console.log(solve_group_anagrams(strs));