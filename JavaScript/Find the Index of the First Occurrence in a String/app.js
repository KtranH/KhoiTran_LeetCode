const haystack = "sadbutsad";
const needle = "sad";

/*
Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
First occurrence is at index 0, so we return 0.
Example 2:

Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
*/

function solve_find_index_of_first_occurrence_in_a_string(haystack, needle) {
    if (haystack.includes(needle)) {
        return haystack.indexOf(needle);
    }
    return -1;
}

console.log(solve_find_index_of_first_occurrence_in_a_string(haystack, needle));
