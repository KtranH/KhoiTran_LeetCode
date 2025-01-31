/*Example 1:

Input: s = "IceCreAm"

Output: "AceCreIm"

Explanation:

The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

Example 2:

Input: s = "leetcode"

Output: "leotcede"*/

const s = "IceCreAm";
const vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];

function slove_reverse_vowels(s, vowels) {
    let arrS = s.split('');
    let count = arrS.length;
    for(let i = 0; i < arrS.length; i++) {
        if(vowels.includes(arrS[i])) {
            for(let j = (arrS.length - 1) - (arrS.length - count); j > i; j--) {
                if(vowels.includes(arrS[j])) {
                    let temp = arrS[i];
                    arrS[i] = arrS[j];
                    arrS[j] = temp;
                    count = j;
                    break;
                }
            }
        }
    }
    return arrS.join('');
}

console.log(slove_reverse_vowels(s, vowels));

