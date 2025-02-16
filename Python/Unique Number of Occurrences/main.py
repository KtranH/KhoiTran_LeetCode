"""
Example 1:

Input: arr = [1,2,2,1,1,3]
Output: true
Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.
Example 2:

Input: arr = [1,2]
Output: false
Example 3:

Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
Output: true
"""

arr = [-3,0,1,-3,1,1,1,-3,10,0]

def solve_unique_number_of_occurrences(arr):
    hashmap = {}
    for num in arr:
        if num in hashmap:
            hashmap[num] += 1
        else:
            hashmap[num] = 1
    hashset = set(hashmap.values())
    if len(hashset) != len(hashmap): return False
    return True


print(solve_unique_number_of_occurrences(arr)) # Output: {1: 2, 2: 2, 3: 1}