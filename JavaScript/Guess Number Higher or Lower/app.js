/*Example 1:

Input: n = 10, pick = 6
Output: 6
Example 2:

Input: n = 1, pick = 1
Output: 1
Example 3:

Input: n = 2, pick = 1
Output: 1*/

const n = 10


var guess = function(num) {
    return 0;
}

var solve_guess_number = function(n) {
    let left = 1;
    let right = n;
    while (left <= right) {
        let mid = Math.floor((left + right) / 2);
        if (guess(mid) === 0) {
            return mid;
        } else if (guess(mid) === -1) {
            right = mid - 1;
        } else {
            left = mid + 1;
        }
    }   
    return -1;
}
