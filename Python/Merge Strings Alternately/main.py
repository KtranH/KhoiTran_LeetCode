"""
Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r

Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1:  a   b 
word2:    p   q   r   s
merged: a p b q   r   s
Example 3:

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"
Explanation: Notice that as word1 is longer, "cd" is appended to the end.
word1:  a   b   c   d
word2:    p   q 
merged: a p b q c   d

Sloved
"""


min = 1
max = 100

def max_length(word1, word2):
    if len(word1) > len(word2):
        return len(word1)
    else:
        return len(word2)
    
word1 = input("Enter a word 1: ")
while len(word1) < min or len(word1) > max:
    print("Please enter a word with legth between 1 and 100")
    word1 = input("Enter a word 1: ")
word2 = input("Enter a word 2: ")
while len(word2) < min or len(word2) > max:
    print("Please enter a word with legth between 1 and 100")
    word2 = input("Enter a word 2: ")

def solve_Merge_Strings_Alternately(word1, word2):
    result = ""
    range_word = max_length(word1, word2)
    for i in range(range_word):
        if(i < len(word1)):
            result += word1[i]
        if(i < len(word2)):
            result += word2[i]
    return result

print(solve_Merge_Strings_Alternately(word1, word2))