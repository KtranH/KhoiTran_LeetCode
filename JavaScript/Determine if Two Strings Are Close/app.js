/*Example 1:

Input: word1 = "abc", word2 = "bca"
Output: true
Explanation: You can attain word2 from word1 in 2 operations.
Apply Operation 1: "abc" -> "acb"
Apply Operation 1: "acb" -> "bca"
Example 2:

Input: word1 = "a", word2 = "aa"
Output: false
Explanation: It is impossible to attain word2 from word1, or vice versa, in any number of operations.
Example 3:

Input: word1 = "cabbba", word2 = "abbccc"
Output: true
Explanation: You can attain word2 from word1 in 3 operations.
Apply Operation 1: "cabbba" -> "caabbb"
Apply Operation 2: "caabbb" -> "baaccc"
Apply Operation 2: "baaccc" -> "abbccc"*/

const word1 = "abc"
const word2 = "bca"

function solve_determine_if_two_string_are_close(word1, word2) {
    if (word1.length != word2.length) {
        return false;
    }

    let map1 = new Map();
    let map2 = new Map();

    for (let i = 0; i < word1.length; i++) {
        map1.set(word1[i], (map1.get(word1[i]) || 0) + 1);
        map2.set(word2[i], (map2.get(word2[i]) || 0) + 1);
    }

    for (let char of map1.keys()) {
        if (!map2.has(char)) return false;
    }

    let freqs1 = Array.from(map1.values()).sort((a, b) => a - b);
    let freqs2 = Array.from(map2.values()).sort((a, b) => a - b);
        
    for (let i = 0; i < freqs1.length; i++) {
        if (freqs1[i] !== freqs2[i]) return false;
    }
    
    return true;
}

console.log(solve_determine_if_two_string_are_close(word1, word2)); // Output: true