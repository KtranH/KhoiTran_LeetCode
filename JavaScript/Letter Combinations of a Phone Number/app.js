/*Example 1:

Input: digits = "23"
Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
Example 2:

Input: digits = ""
Output: []
Example 3:

Input: digits = "2"
Output: ["a","b","c"]
*/
const digits = "23";

function backtracking(index, path, digits, lenDigits, phone, result) {
    if (index == lenDigits) {
        result.push(path);
        return;
    }
    const current_digit = digits[index];
    for (const i of phone[current_digit]) {
        backtracking(index + 1, path + i, digits, lenDigits, phone);
    }
}
function solve_letter_combinations(digits) {
    if (digits.length == 0) return [];
    const result = [];
    const lenDigits = digits.length;
    const phone = {
        "2": "abc",
        "3": "def",
        "4": "ghi",
        "5": "jkl",
        "6": "mno",
        "7": "pqrs",
        "8": "tuv",
        "9": "wxyz"
    };
    backtracking(0, "", digits, lenDigits, phone, result);
    return result;
}

const result = solve_letter_combinations(digits);
console.log(result);