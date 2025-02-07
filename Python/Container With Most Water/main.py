
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