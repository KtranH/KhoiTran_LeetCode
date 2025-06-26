const ransomNote = "a", magazine = "b";

/*
Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
*/

function solve_ransom_note(ransomNote, magazine) {
    let map = [];
    for (let i = 0; i < magazine.length; i++) {
        if (map[magazine[i]] !== undefined) {
            map[magazine[i]]++;
        } else {
            map[magazine[i]] = 1;
        }
    }
    for (let i = 0; i < ransomNote.length; i++) {
        if (map[ransomNote[i]] !== undefined) {
            map[ransomNote[i]]--;
        }
        if (map[ransomNote[i]] < 0 || map[ransomNote[i]] === undefined) {
            return false;
        }
    }
    return true;
}

console.log(solve_ransom_note(ransomNote, magazine));