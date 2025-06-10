const s = "A man, a plan, a canal: Panama";

/*Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.
*/

function solve_valid_palindrome(s) {
    s = s.toLowerCase();
    let i = 0;
    let j = s.length - 1;
    while (i < j) {
        if (!s[i].match(/[a-z0-9]/)) {
            i++;
        } else if (!s[j].match(/[a-z0-9]/)) {
            j--;
        } else {
            if (s[i] !== s[j]) {
                return false;
            }
            i++;
            j--;
        }
    }
    return true;
}

console.log(solve_valid_palindrome(s));
