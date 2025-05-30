/*
Example 1:
Input: height = [1,8,6,2,5,4,8,3,7]
Output: 49
Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
Example 2:

Input: height = [1,1]
Output: 1

*/
const height = [1, 8, 6, 2, 5, 4, 8, 3, 7];

function solve_container_with_most_water(height)
{
    let maxArea = 0;
    let left = 0;
    let right = height.length - 1;
    while (left < right)
    {
        maxArea = Math.max(maxArea, Math.min(height[left], height[right]) * (right - left));
        if (height[left] < height[right])
        {
            left++;
        }
        else
        {
            right--;
        }
    }
    return maxArea;
}

console.log(solve_container_with_most_water(height)); // 49