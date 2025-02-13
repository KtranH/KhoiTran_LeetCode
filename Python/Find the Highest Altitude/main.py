"""
Example 1:

Input: gain = [-5,1,5,0,-7]
Output: 1
Explanation: The altitudes are [0,-5,-4,1,1,-6]. The highest is 1.
Example 2:

Input: gain = [-4,-3,-2,-1,4,3,2]
Output: 0
Explanation: The altitudes are [0,-4,-7,-9,-10,-6,-3,-1]. The highest is 0.
"""
gain = [-5,1,5,0,-7]

def solve_find_the_highest_altitude(gain):

    length_gain = len(gain)
    gain.insert(0,0)
    max_altitude, prelix_sum, temp  = 0, 0, 0

    for i in range(length_gain + 1):
    
        prelix_sum += temp
        temp = gain[i]
        gain[i] += prelix_sum

        if gain[i] > max_altitude: max_altitude = gain[i]
    return max_altitude

print(solve_find_the_highest_altitude(gain))