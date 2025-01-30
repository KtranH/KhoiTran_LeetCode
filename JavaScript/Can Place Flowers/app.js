/*Example 1:

Input: flowerbed = [1,0,0,0,1], n = 1
Output: true
Example 2:

Input: flowerbed = [1,0,0,0,1], n = 2
Output: false*/

const flowerbed = [1,0,0,0,1];
const n = 1;

function slove_can_place_flowers(flowerbed, n) {
    let count = 0;
    for (let i = 0; i < flowerbed.length; i++) {
        if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.length - 1 || flowerbed[i + 1] == 0)) {
            count++;
            flowerbed[i] = 1;
            if (count >= n) {
                return true;
            }
        }
    }
    return count >= n ? true : false;
}   

console.log(slove_can_place_flowers(flowerbed, n));