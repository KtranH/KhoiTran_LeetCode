/*
Example 1:

Input: chars = ["a","a","b","b","c","c","c"]
Output: Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]
Explanation: The groups are "aa", "bb", and "ccc". This compresses to "a2b2c3".
Example 2:

Input: chars = ["a"]
Output: Return 1, and the first character of the input array should be: ["a"]
Explanation: The only group is "a", which remains uncompressed since it's a single character.
Example 3:

Input: chars = ["a","b","b","b","b","b","b","b","b","b","b","b","b"]
Output: Return 4, and the first 4 characters of the input array should be: ["a","b","1","2"].
Explanation: The groups are "a" and "bbbbbbbbbbbb". This compresses to "ab12".
*/

const chars = ["a","a","b","b","c","c","c"];

function solve_string_compression(chars) {
    let write_index = 0;
    let read_index = 0;
    let len_chars = chars.length;

    while(read_index < len_chars) {
        let count = 0;
        let current_char = chars[read_index];

        while(read_index < len_chars && chars[read_index] == current_char) {
            read_index++;
            count++;
        }

        chars[write_index] = current_char;
        write_index++;

        if(count > 1) {
            let count_str = count.toString();
            for(let i = 0; i < count_str.length; i++) {
                chars[write_index] = count_str[i];
                write_index++;
            }
        }
    }
    chars.length = write_index;

    return write_index;
}

console.log(solve_string_compression(chars));