"""
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
"""

chars = ["a","b","b","b","b","b","b","b","b","b","b","b","b"]

def solve_string_compression(chars):
    write_index = 0 
    read_index = 0   
    
    while read_index < len(chars):
        char = chars[read_index]
        count = 0
        
        while read_index < len(chars) and chars[read_index] == char:
            read_index += 1
            count += 1

        chars[write_index] = char
        write_index += 1

        if count > 1:
            for digit in str(count):  
                chars[write_index] = digit
                write_index += 1

    del chars[write_index:]

    return write_index

print(solve_string_compression(chars))

