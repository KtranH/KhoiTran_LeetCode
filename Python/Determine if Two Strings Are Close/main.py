from collections import Counter
word1 = "abbzzca"
word2 = "babzzcz"

def solve_determine_if_two_string_are_close(word1, word2):
    if len(word1) != len(word2):
        return False
    
    hashmap1 = Counter(word1)
    hashmap2 = Counter(word2)

    """
    for char in word1:
        hashmap1[char] = hashmap1.get(char, 0) + 1
    for char in word2:
        hashmap2[char] = hashmap2.get(char, 0) + 1
    """

    if set(hashmap1.keys()) != set(hashmap2.keys()):
        return False

    if sorted(hashmap1.values()) != sorted(hashmap2.values()):
        return False
    return True

print(solve_determine_if_two_string_are_close(word1, word2))