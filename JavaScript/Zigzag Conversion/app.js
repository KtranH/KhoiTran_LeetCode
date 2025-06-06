const s = "PAYPALISHIRING";
const numRows = 3;

/*Example 1:

Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"
Example 2:

Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
Explanation:
P     I    N
A   L S  I G
Y A   H R
P     I
Example 3:

Input: s = "A", numRows = 1
Output: "A"*/

function solve_zigzag_conversion(s, numRows) {
    if (numRows === 1 || numRows >= s.length) {
        return s;
    }
    let result = "";
    let step = 2 * (numRows - 1);
    let n = s.length;
    for (let i = 0; i < numRows; i++) {
        for (let j = i; j < n; j += step) {
            result += s[j];
            if (i > 0 && i < numRows - 1 && j + step - 2 * i < n) {
                result += s[j + step - 2 * i];
            }
        }
    }
    return result;
}
console.log(solve_zigzag_conversion(s, numRows));