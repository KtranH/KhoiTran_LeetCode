"""
Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
"""

nums = [1,2,3,4]
result = [1] * len(nums)
length = len(nums)

"""
def slove_product_except_self(nums):
    global count, result
    product = 1
    if count == length:
        return result
    for i in range(length):
        if count != i:
           product *= nums[i]
    result.append(product)
    count += 1
    return slove_product_except_self(nums)

print(slove_product_except_self(nums))
"""

def slove_product_except_self(nums):
    pre_i = 1
    for i in range(length):
        result[i] = pre_i
        pre_i *= nums[i]
    after_i = 1
    for i in reversed(range(length)):
        result[i] *= after_i
        after_i *= nums[i]    
    return result
print(slove_product_except_self(nums))