/*Example 1:

Input: s = "abciiidef", k = 3
Output: 3
Explanation: The substring "iii" contains 3 vowel letters.
Example 2:

Input: s = "aeiou", k = 2
Output: 2
Explanation: Any substring of length 2 contains 2 vowels.
Example 3:

Input: s = "leetcode", k = 3
Output: 2
Explanation: "lee", "eet" and "ode" contain 2 vowels.*/

const s = "abciiidef"
const k = 3

function solve_maximum_number_of_vowels_in_a_substring_of_given_length(s, k)
{
    let vowels = ['a', 'e', 'i', 'o', 'u'];
    let sliding_windows = 0;
    for (let i = 0; i < k; i++) {
        if (vowels.includes(s[i])) sliding_windows++;
    }
    let max_vowels = sliding_windows;
    for (let i = k; i < s.length; i++) {
        if(vowels.includes(s[i - k])) sliding_windows --;
        if(vowels.includes(s[i])) sliding_windows++;
        if(sliding_windows > max_vowels) max_vowels = sliding_windows;
    }
    return max_vowels;
}

console.log(solve_maximum_number_of_vowels_in_a_substring_of_given_length(s, k));