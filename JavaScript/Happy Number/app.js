const n = 19;

/*
Example 1:

Input: n = 19
Output: true
Explanation:
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1
Example 2:

Input: n = 2
Output: false
*/

function solve_happy_number(n) {
    const hash_map = new Map();
    while (n !== 1 && !hash_map.has(n)) {
        hash_map.set(n, true);
        let new_n = 0;
        while (n > 0) {
            const digit = n % 10;
            new_n += digit * digit;
            n = Math.floor(n / 10);
        }
        n = new_n;
    }
    return n === 1;
}

console.log(solve_happy_number(n));
