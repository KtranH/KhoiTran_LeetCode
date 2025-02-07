"""
Exemple 1:
Input: height = [1,8,6,2,5,4,8,3,7]
Output: 49
Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
Example 2:

Input: height = [1,1]
Output: 1
"""

height = [1,8,6,2,5,4,8,3,7]

def solve_container_with_most_water(height):
    max_water = 0
    left_index = 0
    right_index = len(height) - 1
    while right_index > left_index:
          temp = min(height[right_index], height[left_index]) * (right_index - left_index)
          max_water = max(max_water, temp)
          if height[left_index] < height[right_index]:
             left_index += 1
          else:
             right_index -= 1
    return max_water

print(solve_container_with_most_water(height))