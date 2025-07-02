strs = ["eat","tea","tan","ate","nat","bat"]

"""
Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
Example 2:

Input: strs = [""]
Output: [[""]]
"""

def solve_group_anagrams(strs):
    strs_map = {}
    for i in strs:
        c_sort = ''.join(sorted(i))
        if c_sort in strs_map:
            strs_map[c_sort].append(i)
        else:
            strs_map[c_sort] = [i]
    return list(strs_map.values())

print(solve_group_anagrams(strs))
