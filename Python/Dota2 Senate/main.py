"""
Example 1:

Input: senate = "RD"
Output: "Radiant"
Explanation: 
The first senator comes from Radiant and he can just ban the next senator's right in round 1. 
And the second senator can't exercise any rights anymore since his right has been banned. 
And in round 2, the first senator can just announce the victory since he is the only guy in the senate who can vote.
Example 2:

Input: senate = "RDD"
Output: "Dire"
Explanation: 
The first senator comes from Radiant and he can just ban the next senator's right in round 1. 
And the second senator can't exercise any rights anymore since his right has been banned. 
And the third senator comes from Dire and he can ban the first senator's right in round 1. 
And in round 2, the third senator can just announce the victory since he is the only guy in the senate who can vote.
"""

from collections import deque
senate = "RDD"

def solve_dota2_senate(senate):
    queue_radiant = deque()
    queue_dire = deque()
    n = len(senate)
    for i in range(n):
        if senate[i] == 'R':
            queue_radiant.append(i)
        else:
            queue_dire.append(i)
    i = 0
    while queue_radiant and queue_dire:
        r = queue_radiant.popleft()
        d = queue_dire.popleft()
        
        if r < d:
            queue_radiant.append(r + n)  
        else:
            queue_dire.append(d + n)
    
    return "Radiant" if queue_radiant else "Dire"

print(solve_dota2_senate(senate))

