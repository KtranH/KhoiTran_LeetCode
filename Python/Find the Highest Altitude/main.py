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