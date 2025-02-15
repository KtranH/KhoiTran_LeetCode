/*Example 1:

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
Every integer in nums2 is present in nums1. Therefore, answer[1] = [].*/

const nums1  = [1,2,3]
const nums2 = [2,4,6]

function solve_find_the_difference_of_two_arrays(nums1, nums2) {
    let set1 = new Set(nums1);
    let set2 = new Set(nums2);
    let result = [];

    /*let temp = [];
    for (let num of set1) {
        if (!set2.has(num)) {
            temp.push(num);
        }
    }
    result.push(temp);
    temp = [];
    for (let num of set2) {
        if (!set1.has(num)) {
            temp.push(num);
        }
    }
    result.push(temp);*/

    result.push([...set1].filter(x =>!set2.has(x)));
    result.push([...set2].filter(x =>!set1.has(x)));
    return result;
}

console.log(solve_find_the_difference_of_two_arrays(nums1, nums2));