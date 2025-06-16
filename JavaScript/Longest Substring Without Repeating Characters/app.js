const s = "abcabcbb";

/*
Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
*/

function solve_longest_substring_without_repeating_characters(s){
    let n = s.length;
    let left = 0;
    let max_length = 0
    let map = new Map();
    for(let right = 0; right < n; right++){
        let ch = s[right];
        if(map.has(ch) && map.get(ch) >= left){
            left = map.get(ch) + 1;
        }
        map.set(ch, right);
        let temp = right - left + 1;
        if(temp > max_length){
            max_length = temp;
        }
    }
    return max_length;
}

console.log(solve_longest_substring_without_repeating_characters(s));
