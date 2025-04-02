/*Example 1:

Input: piles = [3,6,7,11], h = 8
Output: 4
Example 2:

Input: piles = [30,11,23,4,20], h = 5
Output: 30
Example 3:

Input: piles = [30,11,23,4,20], h = 6
Output: 23

const piles = [3,6,7,11];
const h = 8;*/

const solve_koko_eating_piles = (piles, h) => {
    let left = 1;
    let right = Math.max(...piles);
    while (left < right) {
        let mid = Math.floor((left + right) / 2);
        let hours = 0;
        for (let i = 0; i < piles.length; i++) {
            hours += Math.ceil(piles[i] / mid);
        }
        if (hours > h) {
            left = mid + 1;
        } else {
            right = mid;
        }
    }
    return left;    
}

console.log(solve_koko_eating_piles(piles, h));

