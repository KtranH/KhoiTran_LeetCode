nums = [1,1,1]

def longest_subarray_of_1s_after_deleting_one_element(nums):
    left_index = 0
    zero_count = 0
    max_length = 0

    for right_index in range(len(nums)):
        if nums[right_index] == 0:
            zero_count += 1
        while zero_count > 1:
            if nums[left_index] == 0: zero_count -= 1
            left_index += 1
        length_right = right_index - left_index
        if max_length < length_right: max_length = length_right

    return max_length

print(longest_subarray_of_1s_after_deleting_one_element(nums))