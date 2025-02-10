s = "leetcode"
k = 3
    
def solve_maximum_number_of_vowels_in_a_substring_of_given_length(s, k):
    vowels = {'a', 'e', 'i', 'o', 'u'}
    sliding_window = 0
    for i in range(k):
        if s[i] in vowels:
            sliding_window += 1
    max_vowels = sliding_window    
    for i in range(k, len(s)):
        if s[i-k] in vowels:
            sliding_window -= 1
        if s[i] in vowels:
            sliding_window += 1
        if max_vowels < sliding_window:
            max_vowels = sliding_window
    return max_vowels

print(solve_maximum_number_of_vowels_in_a_substring_of_given_length(s, k))
