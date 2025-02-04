/*Example 1:

Input: s = "the sky is blue"
Output: "blue is sky the"
Example 2:

Input: s = "  hello world  "
Output: "world hello"
Explanation: Your reversed string should not contain leading or trailing spaces.
Example 3:

Input: s = "a good   example"
Output: "example good a"
Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.*/

const s = "the sky is blue";

function solve_reverse_words(s) {
    return s.split(' ').filter(word => word !== '').reverse().join(' ');
}

console.log(solve_reverse_words(s));