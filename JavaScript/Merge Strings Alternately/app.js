/*Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r
Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1:  a   b 
word2:    p   q   r   s
merged: a p b q   r   s
Example 3:

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"
Explanation: Notice that as word1 is longer, "cd" is appended to the end.
word1:  a   b   c   d
word2:    p   q 
merged: a p b q c   d

Sloved
*/

const min = 1;
const max = 100;
const prompt = require("prompt-sync")();

let word1 = prompt("Enter the first word: ");
while (word1.length < min || word1.length > max) {
    console.log("The word must be between 1 and 100 characters long.");
    word1 = prompt("Enter the first word: ");
}
let word2 = prompt("Enter the second word: ");
while (word2.length < min || word2.length > max) {
    console.log("The word must be between 1 and 100 characters long.");
    word2 = prompt("Enter the second word: ");
}

function solve_merge_strings_alternately(word1, word2) {
    let result = "";
    for (let i = 0; i < Math.max(word1.length, word2.length); i++) {
        if (i < word1.length) {
            result += word1[i];
        }
        if (i < word2.length) {
            result += word2[i];
        }
    }
    return result;
}

console.log(solve_merge_strings_alternately(word1, word2));