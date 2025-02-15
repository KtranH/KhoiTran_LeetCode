"""
Example 1:

Input: nums1 = [1,2,3], nums2 = [2,4,6]
Output: [[1,3],[4,6]]
Explanation:
For nums1, nums1[1] = 2 is present at index 0 of nums2, whereas nums1[0] = 1 and nums1[2] = 3 are not present in nums2. Therefore, answer[0] = [1,3].
For nums2, nums2[0] = 2 is present at index 1 of nums1, whereas nums2[1] = 4 and nums2[2] = 6 are not present in nums2. Therefore, answer[1] = [4,6].
Example 2:

Input: nums1 = [1,2,3,3], nums2 = [1,1,2,2]
Output: [[3],[]]
Explanation:
For nums1, nums1[2] and nums1[3] are not present in nums2. Since nums1[2] == nums1[3], their value is only included once and answer[0] = [3].
Every integer in nums2 is present in nums1. Therefore, answer[1] = [].
"""

nums1 = [1,2,3]
nums2 = [2,4,6]

def solve_find_the_difference_of_two_arrays(nums1, nums2):
    nums1 = set(nums1)
    nums2 = set(nums2)
    result = []
    result.append(list(nums1 - nums2))
    result.append(list(nums2 - nums1))
    return result

print(solve_find_the_difference_of_two_arrays(nums1, nums2)) # Output: [1, 3]