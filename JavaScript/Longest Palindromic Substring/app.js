const s = "babad";

/*Example 1:

Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.
Example 2:

Input: s = "cbbd"
Output: "bb"*/

function expand_from_center(left, right, s) {
    while (left >= 0 && right < s.length && s[left] === s[right]) {
        left--;
        right++;
    }
    return s.slice(left + 1, right);
}

function solve_longest_palindromic_substring(s) {
    let result = "";
    for (let i = 0; i < s.length; i++) {
        let s1 = expand_from_center(i, i, s);
        let s2 = expand_from_center(i, i + 1, s);
        result = result.length > s1.length ? result : s1;
        result = result.length > s2.length ? result : s2;
    }
    return result;
}

console.log(solve_longest_palindromic_substring(s));
